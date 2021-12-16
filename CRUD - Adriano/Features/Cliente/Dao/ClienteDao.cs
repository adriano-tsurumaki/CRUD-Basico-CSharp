using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.Sql;
using CRUD___Adriano.Features.Entidades.Email.Model;
using CRUD___Adriano.Features.Entidades.Email.Sql;
using CRUD___Adriano.Features.Entidades.Endereco.Model;
using CRUD___Adriano.Features.Entidades.Endereco.Sql;
using CRUD___Adriano.Features.Entidades.Telefone.Model;
using CRUD___Adriano.Features.Entidades.Telefone.Sql;
using CRUD___Adriano.Features.Usuario.Sql;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CRUD___Adriano.Features.Cliente.Dao
{
    public class ClienteDao
    {
        private IDbConnection _conexao;

        public ClienteDao(IDbConnection conexao)
        {
            _conexao = conexao;
        }

        public bool CadastrarCliente(ClienteModel clienteModel)
        {
            try
            {
                _conexao.Open();
                using var transacao = _conexao.BeginTransaction();

                clienteModel.IdUsuario = (int)_conexao.ExecuteScalar(UsuarioSql.Inserir, UsuarioSql.RetornarParametroDinamicoDaModel(clienteModel), transacao);

                _conexao.Execute(ClienteSql.Inserir(clienteModel), ClienteSql.RetornarParametroDinamicoDaModel(clienteModel), transacao);

                clienteModel.Endereco.IdUsuario = clienteModel.IdUsuario;

                foreach (var email in clienteModel.Emails)
                    email.IdUsuario = clienteModel.IdUsuario;

                foreach (var telefone in clienteModel.Telefones)
                    telefone.IdUsuario = clienteModel.IdUsuario;

                _conexao.Execute(EnderecoSql.Inserir(clienteModel.Endereco), clienteModel.Endereco, transacao);
                _conexao.Execute(EmailSql.Inserir, clienteModel.Emails, transacao);
                _conexao.Execute(TelefoneSql.Inserir, clienteModel.Telefones, transacao);

                transacao.Commit();
                return true;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public IList<ClienteModel> ListarTodosOsClientes()
        {
            try
            {
                _conexao.Open();
                var dicionarioCliente = new Dictionary<int, ClienteModel>();

                _conexao.Query<ClienteModel, EnderecoModel, ClienteModel>(
                    ClienteSql.ListarTodos,
                    (clienteModel, enderecoModel) =>
                    MapearListagemDeClientes(clienteModel, enderecoModel, dicionarioCliente),
                    splitOn: "split");

                _conexao.Query<ClienteModel, EmailModel, ClienteModel>(
                    EmailSql.ListarTodos,
                    (clienteModel, emailModel) => MapearListagemDeEmailsDosClientes(clienteModel, emailModel, dicionarioCliente),
                    splitOn: "split");

                _conexao.Query<ClienteModel, TelefoneModel, ClienteModel>(
                    TelefoneSql.ListarTodos,
                    (clienteModel, telefoneModel) => MapearListagemDeTelefonesDosClientes(clienteModel, telefoneModel, dicionarioCliente),
                    splitOn: "split");
                
                return dicionarioCliente.Values.ToList();
            }
            finally
            {
                _conexao.Close();
            }
        }

        private ClienteModel MapearListagemDeClientes(ClienteModel clienteModel, EnderecoModel enderecoModel, Dictionary<int, ClienteModel> dicionarioCliente)
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

        private ClienteModel MapearListagemDeEmailsDosClientes(ClienteModel clienteModel, EmailModel emailModel, Dictionary<int, ClienteModel> dicionarioCliente)
        {
            if(dicionarioCliente.TryGetValue(clienteModel.IdUsuario, out var cliente))
                cliente.Emails.Add(emailModel);

            return clienteModel;
        }

        private ClienteModel MapearListagemDeTelefonesDosClientes(ClienteModel clienteModel, TelefoneModel telefoneModel, Dictionary<int, ClienteModel> dicionarioCliente)
        {
            if(dicionarioCliente.TryGetValue(clienteModel.IdUsuario, out var cliente))
                cliente.Telefones.Add(telefoneModel);

            return clienteModel;
        }

        public IList<ClienteModel> ListarTodosOsClientesSomenteIdENome() =>
            _conexao.Query<ClienteModel>(ClienteSql.ListarTodosComCamposSomenteIdENome).ToList();

        public IList<ClienteModel> ListarPelaQuantidadeSomenteIdENome(int quantidade) =>
            _conexao.Query<ClienteModel>(ClienteSql.ListarPelaQuantidadeComCamposSomenteIdENome, new { quantidade }).ToList();

        public IList<ClienteModel> ListarClientesPeloNomeSomenteIdENome(string nome) =>
            _conexao.Query<ClienteModel>(ClienteSql.ListarPeloNomeComCamposSomenteIdENome, new { nome }).ToList();

        public ClienteModel SelecionarCliente(int id)
        {
            var cliente = _conexao.QuerySingleOrDefault<ClienteModel>(ClienteSql.Selecionar, new { id });

            cliente.Endereco = _conexao.QuerySingleOrDefault<EnderecoModel>(EnderecoSql.SelecionarUm, new { id });
            cliente.Emails = _conexao.Query<EmailModel>(EmailSql.ListarTodosPorId, new { id }).ToList();
            cliente.Telefones = _conexao.Query<TelefoneModel>(TelefoneSql.ListarTodosPorId, new { id }).ToList();

            return cliente;
        }

        public ClienteModel SelecionarClienteSomenteIdENome(int id) =>
            _conexao.QuerySingleOrDefault<ClienteModel>(ClienteSql.SelecionarComCamposSomenteIdENome, new { id });

        public int SelecionarQuantidadeDeTodosOsClientes() =>
            _conexao.QuerySingleOrDefault<int>(ClienteSql.SelecionarQuantidadeDeTodos);

        public DateTime SelecionarDataDeNascimento(int idUsuario)
        {
            try
            {
                _conexao.Open();
                return _conexao.QuerySingleOrDefault<DateTime>("select u.data_nascimento from Cliente c inner join Usuario u on u.id = c.id_usuario where u.id = @idUsuario", new { idUsuario });
            }
            finally
            {
                _conexao.Close();
            }
        }

        public bool RemoverCliente(int id)
        {
            try
            {
                _conexao.Open();
                using var transacao = _conexao.BeginTransaction();

                _conexao.Query("delete Cliente where id_usuario = @id", new { id }, transacao);
                _conexao.Query(EnderecoSql.Remover, new { id }, transacao);
                _conexao.Query(EmailSql.Remover, new { id }, transacao);
                _conexao.Query(TelefoneSql.Remover, new { id }, transacao);
                _conexao.Query(UsuarioSql.Remover, new { id }, transacao);

                transacao.Commit();
                return true;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public bool AtualizarCliente(ClienteModel clienteModel)
        {
            try
            {
                _conexao.Open();
                using var transacao = _conexao.BeginTransaction();

                _conexao.Execute(UsuarioSql.Atualizar, UsuarioSql.RetornarParametroDinamicoDaModel(clienteModel), transacao);
                _conexao.Execute(ClienteSql.Atualizar(clienteModel), ClienteSql.RetornarParametroDinamicoDaModel(clienteModel), transacao);
                _conexao.Execute(EnderecoSql.Atualizar(clienteModel.Endereco), clienteModel.Endereco, transacao);

                foreach (var email in clienteModel.Emails)
                {
                    if (email.Id > 0)
                        _conexao.Execute(EmailSql.Atualizar, email, transacao);
                    else
                    {
                        email.IdUsuario = clienteModel.IdUsuario;
                        _conexao.Execute(EmailSql.Inserir, email, transacao);
                    }
                }
                foreach (var telefone in clienteModel.Telefones)
                {
                    if (telefone.Id > 0)
                        _conexao.Execute(TelefoneSql.Atualizar, telefone, transacao);
                    else
                    {
                        telefone.IdUsuario = clienteModel.IdUsuario;
                        _conexao.Execute(TelefoneSql.Inserir, telefone, transacao);
                    }
                }

                transacao.Commit();

                return true;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public double RetornarValorLimite(int idUsuario)
        {
            try
            {
                _conexao.Open();
                return _conexao.QuerySingleOrDefault<double>("select valor_limite from Cliente where id_usuario = @idUsuario", new { idUsuario });
            }
            finally
            {
                _conexao.Close();
            }
        }

        public double RetornarValorLimiteRestante(int idUsuario)
        {
            try
            {
                _conexao.Open();
                var clienteModel = _conexao.QuerySingleOrDefault<ClienteModel>(ClienteSql.ValorLimiteRestante, new { idUsuario });
                if (clienteModel is null)
                    return _conexao.QuerySingleOrDefault<ClienteModel>(ClienteSql.ValorLimite, new { idUsuario }).ValorLimite.Valor;
                else
                    return clienteModel.ValorLimite.Valor;
            }
            finally
            {
                _conexao.Close();
            }
        }
    }
}
