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
            @"insert into Usuario(nome, sobrenome, sexo, data_nascimento) 
            output inserted.id
            values(@Nome, @Sobrenome, @Sexo, @DataNascimento)";

        private static string sqlInserirCliente =
            @"insert into Cliente(id_usuario, valor_limite)
            values (@Id, @ValorLimite)";

        public static void CadastrarCliente(IDbConnection conexao, ClienteModel clienteModel)
        {
            clienteModel.Id = (int)conexao.ExecuteScalar(sqlInserirUsuario, clienteModel);
            conexao.Execute(sqlInserirCliente, clienteModel);
        }

    }
}
