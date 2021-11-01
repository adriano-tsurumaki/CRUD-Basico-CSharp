using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.Sql;
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
        public static bool CadastrarCliente(IDbConnection conexao, IDbTransaction transacao, ClienteModel clienteModel)
        {
            clienteModel.IdUsuario = (int)conexao.ExecuteScalar(UsuarioSql.Inserir, clienteModel, transacao);

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

        public static IList<ClienteModel> ListarTodosOsClientes(IDbConnection conexao)
        {
            var dicionarioCliente = new Dictionary<int, ClienteModel>();

            conexao.Query<ClienteModel, EnderecoModel, ClienteModel>(
                ClienteSql.sqlListarTodosOsClientes, 
                (clienteModel, enderecoModel) => 
                MapearListagemDeClientes(clienteModel, enderecoModel, dicionarioCliente),
                splitOn: "split");

            conexao.Query<ClienteModel, EmailModel, ClienteModel>(
                EmailSql.ListarTodos,
                (clienteModel, emailModel) => MapearListagemDeEmailsDosClientes(clienteModel, emailModel, dicionarioCliente),
                splitOn: "split");
            
            conexao.Query<ClienteModel, TelefoneModel, ClienteModel>(
                TelefoneSql.ListarTodos,
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

        public static IList<ClienteModel> ListarTodosOsClientesSomenteIdENome(IDbConnection conexao) =>
            conexao.Query<ClienteModel>(ClienteSql.sqlListarTodosOsClientesComCamposSomenteIdENome).ToList();

        public static IList<ClienteModel> ListarClientesPeloNomeSomenteIdENome(IDbConnection conexao, string Nome) =>
            conexao.Query<ClienteModel>(ClienteSql.sqlListarClientesPeloNomeComCamposSomenteIdENome, new { Nome }).ToList();

        public static IList<ClienteModel> ListarAlgunsClientesSomenteIdENome(IDbConnection conexao, int Quantidade) =>
            conexao.Query<ClienteModel>(ClienteSql.sqlListarAlgunsClientesComCamposSomenteIdENome, new { Quantidade }).ToList();

        public static ClienteModel SelecionarCliente(IDbConnection conexao, int id)
        {
            var cliente = conexao.QuerySingleOrDefault<ClienteModel>(ClienteSql.sqlSelecionarCliente, new { id });

            cliente.Endereco = conexao.QuerySingleOrDefault<EnderecoModel>(EnderecoSql.SelecionarUm, new { id });
            cliente.Emails = conexao.Query<EmailModel>(EmailSql.ListarTodosPorId, new { id }).ToList();
            cliente.Telefones = conexao.Query<TelefoneModel>(TelefoneSql.ListarTodosPorId, new { id }).ToList();

            return cliente;
        }

        public static ClienteModel SelecionarClienteSomenteIdENome(IDbConnection conexao, int id) =>
            conexao.QuerySingleOrDefault<ClienteModel>(ClienteSql.sqlSelecionarClienteComCamposSomenteIdENome, new { id });

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
                if (email.Id > 0)
                    conexao.Execute(EmailSql.Atualizar, email, transacao);
                else
                {
                    email.IdUsuario = clienteModel.IdUsuario;
                    conexao.Execute(EmailSql.Inserir, email, transacao);
                }
            }
            foreach (var telefone in clienteModel.Telefones)
            {
                if (telefone.Id > 0)
                    conexao.Execute(TelefoneSql.Atualizar, telefone, transacao);
                else
                {
                    telefone.IdUsuario = clienteModel.IdUsuario;
                    conexao.Execute(TelefoneSql.Inserir, telefone, transacao);
                }
            }

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

        private static string SqlAtualizarCliente(ClienteModel clienteModel)
        {
            var updateSql = new StringBuilder(@"update Cliente set 
            valor_limite = @ValorLimite");

            if (!string.IsNullOrEmpty(clienteModel.Observacao))
                updateSql.Append(", observacao = @Observacao ");

            updateSql.Append(" where id_usuario = @IdUsuario");

            return updateSql.ToString();
        }
    }
}
