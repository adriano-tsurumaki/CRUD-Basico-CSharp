using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Endereco.Model;
using Dapper;
using System.Data;
using System.Text;
using System.Linq;

namespace CRUD___Adriano.Features.Cliente.Dao
{
    public class ClienteDao
    {
        private static string sqlInserirUsuario = 
            @"insert into Usuario(nome, sobrenome, sexo, data_nascimento, cpf) 
            output inserted.id
            values(@Nome, @Sobrenome, @Sexo, @DataNascimento, @Cpf)";

        private static string sqlInserirEmail =
            @"insert into Email(id_usuario, nome) values (@IdUsuario, @Nome)";
        
        private static string sqlInserirTelefone =
            @"insert into Telefone(id_usuario, numero, tipo) values (@IdUsuario, @Numero, @Tipo)";

        public static void CadastrarCliente(IDbConnection conexao, IDbTransaction transacao, ClienteModel clienteModel)
        {
            clienteModel.Id = (int)conexao.ExecuteScalar(sqlInserirUsuario, clienteModel, transacao);

            conexao.Execute(SqlInserirCliente(clienteModel), clienteModel, transacao);

            clienteModel.Endereco.IdUsuario = clienteModel.Id;

            foreach (var email in clienteModel.Emails)
                email.IdUsuario = clienteModel.Id;

            foreach (var telefone in clienteModel.Telefones)
                telefone.IdUsuario = clienteModel.Id;

            conexao.Execute(SqlInserirEndereco(clienteModel.Endereco), clienteModel.Endereco, transacao);
            conexao.Execute(sqlInserirEmail, clienteModel.Emails, transacao);
            conexao.Execute(sqlInserirTelefone, clienteModel.Telefones, transacao);
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
            var valuesSql = new StringBuilder("values (@IdUsuario, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @Numero");

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
