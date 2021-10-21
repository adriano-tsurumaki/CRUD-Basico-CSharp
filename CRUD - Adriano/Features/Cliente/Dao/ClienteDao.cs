using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Endereco.Model;
using Dapper;
using System.Data;
using System.Text;

namespace CRUD___Adriano.Features.Cliente.Dao
{
    public class ClienteDao
    {
        private static string sqlInserirUsuario = 
            @"insert into Usuario(nome, sobrenome, sexo, data_nascimento, cpf) 
            output inserted.id
            values(@Nome, @Sobrenome, @Sexo, @DataNascimento, @Cpf)";

        public static void CadastrarCliente(IDbConnection conexao, IDbTransaction transacao, ClienteModel clienteModel)
        {
            clienteModel.Id = (int)conexao.ExecuteScalar(sqlInserirUsuario, clienteModel, transacao);
            conexao.Execute(SqlInserirCliente(clienteModel), clienteModel, transacao);

            clienteModel.Endereco.IdUsuario = clienteModel.Id;

            conexao.Execute(SqlInserirEndereco(clienteModel.Endereco), clienteModel.Endereco, transacao);
        }

        private static string SqlInserirCliente(ClienteModel clienteModel)
        {
            var insertSql = new StringBuilder("insert into Cliente(id_usuario, valor_limite");
            var valuesSql = new StringBuilder("values (@Id, @ValorLimite");

            if (!string.IsNullOrEmpty(clienteModel.Observacao))
            {
                insertSql.Append(", observacao");
                valuesSql.Append(", @Observacao");
            }

            insertSql.Append(")");
            valuesSql.Append(")");
            return string.Join(' ', insertSql, valuesSql);
        }

        private static string SqlInserirEndereco(EnderecoModel enderecoModel)
        {
            var insertSql = new StringBuilder("insert into Endereco(id_usuario, logradouro, cidade, uf, complemento, bairro, numero");
            var valuesSql = new StringBuilder("values (@Id, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @Numero");

            if (!string.IsNullOrEmpty(enderecoModel.Cep))
            {
                insertSql.Append(", cep");
                valuesSql.Append(", @Cep");
            }

            insertSql.Append(")");
            valuesSql.Append(")");
            return string.Join(' ', insertSql, valuesSql);
        }

    }
}
