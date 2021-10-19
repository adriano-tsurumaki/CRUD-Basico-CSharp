using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.Model;
using Dapper;
using Dommel;
using System.Data;

namespace CRUD___Adriano.Features.Cliente.Dao
{
    public class ClienteDao
    {
        private static string sqlInserirUsuario = 
            @"insert into Usuario(nome, sobrenome, sexo, data_nascimento, cpf) 
            output inserted.id
            values(@Nome, @Sobrenome, @Sexo, @DataNascimento, @Cpf)";

        private static string sqlInserirCliente =
            @"insert into Cliente(id_usuario, valor_limite)
            values (@Id, @ValorLimite)";

        private static string sqlInserirEndereco =
            @"insert into Endereco(id_usuario, cep, logradouro, 
            cidade, uf, complemento, bairro, numero)
            values (@Id, @Cep, @Logradouro, @Cidade, 
            @Uf, @Complemento, @Bairro, @Numero)";

        public static void CadastrarCliente(IDbConnection conexao, IDbTransaction transacao, ClienteModel clienteModel)
        {
            clienteModel.Id = (int)conexao.ExecuteScalar(sqlInserirUsuario, clienteModel, transacao);
            conexao.Execute(sqlInserirCliente, clienteModel, transacao);
            conexao.Execute(sqlInserirEndereco, new { clienteModel.Endereco, clienteModel.Id }, transacao);
        }

        private static void ConstruirSql()
        {
            
        }
    }
}
