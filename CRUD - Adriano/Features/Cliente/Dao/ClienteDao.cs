using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Email.Model;
using CRUD___Adriano.Features.Email.Sql;
using CRUD___Adriano.Features.Endereco.Model;
using CRUD___Adriano.Features.Endereco.Sql;
using CRUD___Adriano.Features.Telefone.Model;
using CRUD___Adriano.Features.Telefone.Sql;
using CRUD___Adriano.Features.Usuario.Sql;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CRUD___Adriano.Features.Cliente.Dao
{
    public class ClienteDao
    {
        private static readonly string sqlInserirUsuario = 
            @"insert into Usuario(nome, sobrenome, sexo, data_nascimento, cpf) 
            output inserted.id
            values(@Nome, @Sobrenome, @Sexo, @DataNascimento, @Cpf)";

        private static readonly string sqlListarTodosOsClientes =
            @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento, c.valor_limite as ValorLimite, c.observacao,
            c.id as split, en.id_usuario as IdUsuario, en.cep, en.logradouro, en.bairro, en.cidade, en.uf, en.complemento, en.numero
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario
			inner join Endereco en on en.id_usuario = u.id";

        public static bool CadastrarCliente(IDbConnection conexao, IDbTransaction transacao, ClienteModel clienteModel)
        {
            clienteModel.IdUsuario = (int)conexao.ExecuteScalar(sqlInserirUsuario, clienteModel, transacao);

            conexao.Execute(SqlInserirCliente(clienteModel), clienteModel, transacao);

            clienteModel.Endereco.IdUsuario = clienteModel.IdUsuario;

            foreach (var email in clienteModel.Emails)
                email.IdUsuario = clienteModel.IdUsuario;

            foreach (var telefone in clienteModel.Telefones)
                telefone.IdUsuario = clienteModel.IdUsuario;

            conexao.Execute(EnderecoSql.Inserir(clienteModel.Endereco), clienteModel.Endereco, transacao);
            conexao.Execute(EmailSql.Inserir, clienteModel.Emails, transacao);
            conexao.Execute(TelefoneSql.Inserir, clienteModel.Telefones, transacao);

            return true;
        }

        public static string SqlInserirCliente(ClienteModel clienteModel)
        {
            var insertSql = new StringBuilder("insert into Cliente(id_usuario, valor_limite");
            var valuesSql = new StringBuilder("values (@IdUsuario, @ValorLimite");

            if (!string.IsNullOrEmpty(clienteModel.Observacao))
            {
                insertSql.Append(", observacao");
                valuesSql.Append(", @Observacao");
            }

            insertSql.Append(")");
            valuesSql.Append(")");
            return string.Join(' ', insertSql, valuesSql);
        }

        public static IList<ClienteModel> ListarClientes(IDbConnection conexao)
        {
            var dicionarioCliente = new Dictionary<int, ClienteModel>();

            conexao.Query<ClienteModel, EnderecoModel, ClienteModel>(
                sqlListarTodosOsClientes, 
                (clienteModel, enderecoModel) => 
                MapearListagemDeClientes(clienteModel, enderecoModel, dicionarioCliente),
                splitOn: "split");

            conexao.Query<ClienteModel, EmailModel, ClienteModel>(
                EmailSql.ListarTodosPorId,
                (clienteModel, emailModel) => MapearListagemDeEmailsDosClientes(clienteModel, emailModel, dicionarioCliente),
                splitOn: "split");
            
            conexao.Query<ClienteModel, TelefoneModel, ClienteModel>(
                TelefoneSql.ListarTodosPorId,
                (clienteModel, telefoneModel) => MapearListagemDeTelefonesDosClientes(clienteModel, telefoneModel, dicionarioCliente),
                splitOn: "split");

            return dicionarioCliente.Values.ToList();
        }

        private static ClienteModel MapearListagemDeClientes(ClienteModel clienteModel, EnderecoModel enderecoModel, Dictionary<int, ClienteModel> dicionarioCliente)
        {
            if (dicionarioCliente.TryGetValue(clienteModel.IdUsuario, out var cliente) && cliente.Endereco.Id != enderecoModel.Id)
                    cliente.Endereco = enderecoModel;
            else
            {
                clienteModel.Endereco = enderecoModel;
                dicionarioCliente.Add(clienteModel.IdUsuario, clienteModel);
            }

            return clienteModel;
        }

        private static ClienteModel MapearListagemDeEmailsDosClientes(ClienteModel clienteModel, EmailModel emailModel, Dictionary<int, ClienteModel> dicionarioCliente)
        {
            if(dicionarioCliente.TryGetValue(clienteModel.IdUsuario, out var cliente))
                cliente.Emails.Add(emailModel);

            return clienteModel;
        }

        private static ClienteModel MapearListagemDeTelefonesDosClientes(ClienteModel clienteModel, TelefoneModel telefoneModel, Dictionary<int, ClienteModel> dicionarioCliente)
        {
            if(dicionarioCliente.TryGetValue(clienteModel.IdUsuario, out var cliente))
                cliente.Telefones.Add(telefoneModel);

            return clienteModel;
        }

        private static readonly string sqlSelecionarCliente =
            @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento, c.valor_limite as ValorLimite, c.observacao,
            c.id as split, en.id_usuario as IdUsuario, en.cep, en.logradouro, en.bairro, en.cidade, en.uf, en.complemento, en.numero
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario
			inner join Endereco en on en.id_usuario = u.id
			where u.id = @id";

        public static ClienteModel SelecionarCliente(IDbConnection conexao, int id)
        {
            var dicionarioCliente = new Dictionary<int, ClienteModel>();

            conexao.Query<ClienteModel, EnderecoModel, ClienteModel>(
                sqlSelecionarCliente,
                (clienteModel, enderecoModel) =>
                MapearListagemDeClientes(clienteModel, enderecoModel, dicionarioCliente),
                splitOn: "split",
                param: new { id });

            conexao.Query<ClienteModel, EmailModel, ClienteModel>(
                EmailSql.ListarTodosPorId,
                (clienteModel, emailModel) => MapearListagemDeEmailsDosClientes(clienteModel, emailModel, dicionarioCliente),
                splitOn: "split");

            conexao.Query<ClienteModel, TelefoneModel, ClienteModel>(
                TelefoneSql.ListarTodosPorId,
                (clienteModel, telefoneModel) => MapearListagemDeTelefonesDosClientes(clienteModel, telefoneModel, dicionarioCliente),
                splitOn: "split");

            return dicionarioCliente.Values.First();
        }

        public static bool RemoverCliente(IDbConnection conexao, IDbTransaction transacao, int id)
        {
            conexao.Query("delete Cliente where id_usuario = @id", new { id }, transacao);
            conexao.Query(EnderecoSql.Remover, new { id }, transacao);
            conexao.Query(EmailSql.Remover, new { id }, transacao);
            conexao.Query(TelefoneSql.Remover, new { id }, transacao);
            conexao.Query(UsuarioSql.Remover, new { id }, transacao);

            return true;
        }

        public static bool AtualizarCliente(IDbConnection conexao, IDbTransaction transacao, ClienteModel clienteModel)
        {
            conexao.Execute(UsuarioSql.Atualizar, clienteModel, transacao);
            conexao.Execute(SqlAtualizarCliente(clienteModel), clienteModel, transacao);
            conexao.Execute(EnderecoSql.Atualizar(clienteModel.Endereco), clienteModel.Endereco, transacao);

            foreach (var email in clienteModel.Emails)
            {
                email.Nome = "123456789";
                conexao.Execute(EmailSql.Atualizar, email, transacao);
            }
            foreach (var telefone in clienteModel.Telefones)
            {
                telefone.Numero = "1234568";
                conexao.Execute(TelefoneSql.Atualizar, telefone, transacao);
            }

            return true;
        }

        private static string SqlAtualizarCliente(ClienteModel clienteModel)
        {
            var updateSql = new StringBuilder(@"update Cliente set 
            valor_limite = @ValorLimite");

            if (!string.IsNullOrEmpty(clienteModel.Observacao))
                updateSql.Append(", observacao = @Observacao ");

            updateSql.Append("where id_usuario = @IdUsuario");

            return updateSql.ToString();
        }
    }
}
