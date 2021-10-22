using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Email.Model;
using CRUD___Adriano.Features.Endereco.Model;
using CRUD___Adriano.Features.Telefone.Model;
using CRUD___Adriano.Features.Usuario.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

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
            clienteModel.IdUsuario = (int)conexao.ExecuteScalar(sqlInserirUsuario, clienteModel, transacao);

            conexao.Execute(SqlInserirCliente(clienteModel), clienteModel, transacao);

            clienteModel.Endereco.IdUsuario = clienteModel.IdUsuario;

            foreach (var email in clienteModel.Emails)
                email.IdUsuario = clienteModel.IdUsuario;

            foreach (var telefone in clienteModel.Telefones)
                telefone.IdUsuario = clienteModel.IdUsuario;

            conexao.Execute(SqlInserirEndereco(clienteModel.Endereco), clienteModel.Endereco, transacao);
            conexao.Execute(sqlInserirEmail, clienteModel.Emails, transacao);
            conexao.Execute(sqlInserirTelefone, clienteModel.Telefones, transacao);
        }

        private static string SqlInserirCliente(ClienteModel clienteModel)
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

        private static string sqlListarTodosOsClientes =
            @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento, c.valor_limite as ValorLimite, c.observacao,
            c.id as split, en.id_usuario as IdUsuario, en.cep, en.logradouro, en.bairro, en.cidade, en.uf, en.complemento, en.numero
			from Cliente c
			inner join Usuario u on u.id = c.id_usuario
			inner join Endereco en on en.id_usuario = u.id";

        private static string sqlListarEmailsPorId =
            @"select u.id as IdUsuario,
			c.id as split, e.id, e.id_usuario as IdUsuario, e.nome
			from Usuario u
			inner join Cliente c on c.id_usuario = u.id
			inner join Email e on e.id_usuario = u.id";
        
        private static string sqlListarTelefonesPorId =
            @"select u.id as IdUsuario, 
			c.id as split, t.id, t.id_usuario as IdUsuario, t.numero, t.tipo
			from Usuario u
			inner join Cliente c on c.id_usuario = u.id
            inner join Telefone t on t.id_usuario = u.id";

        public static IList<ClienteModel> ListarClientes(IDbConnection conexao)
        {
            var dicionarioCliente = new Dictionary<int, ClienteModel>();

            conexao.Query<ClienteModel, EnderecoModel, ClienteModel>(
                sqlListarTodosOsClientes, 
                (clienteModel, enderecoModel) => 
                MapearListagemDeClientes(clienteModel, enderecoModel, dicionarioCliente),
                splitOn: "split");

            conexao.Query<ClienteModel, EmailModel, ClienteModel>(
                sqlListarEmailsPorId,
                (clienteModel, emailModel) => MapearListagemDeEmailsDosClientes(clienteModel, emailModel, dicionarioCliente),
                splitOn: "split");
            
            conexao.Query<ClienteModel, TelefoneModel, ClienteModel>(
                sqlListarTelefonesPorId,
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
            dicionarioCliente.TryGetValue(clienteModel.IdUsuario, out var cliente);

            cliente.Emails.Add(emailModel);

            return clienteModel;
        }

        private static ClienteModel MapearListagemDeTelefonesDosClientes(ClienteModel clienteModel, TelefoneModel telefoneModel, Dictionary<int, ClienteModel> dicionarioCliente)
        {
            dicionarioCliente.TryGetValue(clienteModel.IdUsuario, out var cliente);

            cliente.Telefones.Add(telefoneModel);

            return clienteModel;
        }
    }
}
