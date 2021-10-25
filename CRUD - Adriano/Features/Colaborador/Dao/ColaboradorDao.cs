using CRUD___Adriano.Features.Cliente.Model;
using CRUD___Adriano.Features.Email.Model;
using CRUD___Adriano.Features.Email.Sql;
using CRUD___Adriano.Features.Endereco.Model;
using CRUD___Adriano.Features.Endereco.Sql;
using CRUD___Adriano.Features.Telefone.Model;
using CRUD___Adriano.Features.Telefone.Sql;
using CRUD___Adriano.Features.Usuario.Sql;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CRUD___Adriano.Features.Colaborador.Dao
{
    public class ColaboradorDao
    {
        private static readonly string sqlInserirUsuario =
            @"insert into Usuario(nome, sobrenome, sexo, data_nascimento, cpf) 
            output inserted.id
            values(@Nome, @Sobrenome, @Sexo, @DataNascimento, @Cpf)";

        private static readonly string sqlInserirColaborador =
            @"insert into Colaborador(id_usuario, salario, comissao)
            values(@IdUsuario, @Salario, @Comissao)";

        private static readonly string sqlInserirEmail =
            @"insert into Email(id_usuario, nome) values (@IdUsuario, @Nome)";

        private static readonly string sqlInserirTelefone =
            @"insert into Telefone(id_usuario, numero, tipo) values (@IdUsuario, @Numero, @Tipo)";

        private static readonly string sqlListarTodosOsColaboradores =
            @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento, c.salario, c.comissao,
            c.id as split, en.id_usuario as IdUsuario, en.cep, en.logradouro, en.bairro, en.cidade, en.uf, en.complemento, en.numero
			from Colaborador c
			inner join Usuario u on u.id = c.id_usuario
			inner join Endereco en on en.id_usuario = u.id";

        public static bool CadastrarColaborador(IDbConnection conexao, IDbTransaction transacao, ColaboradorModel colaboradorModel)
        {
            colaboradorModel.IdUsuario = (int)conexao.ExecuteScalar(sqlInserirUsuario, colaboradorModel, transacao);

            conexao.Execute(sqlInserirColaborador, colaboradorModel, transacao);

            colaboradorModel.Endereco.IdUsuario = colaboradorModel.IdUsuario;

            foreach (var email in colaboradorModel.Emails)
                email.IdUsuario = colaboradorModel.IdUsuario;

            foreach (var telefone in colaboradorModel.Telefones)
                telefone.IdUsuario = colaboradorModel.IdUsuario;

            conexao.Execute(SqlInserirEndereco(colaboradorModel.Endereco), colaboradorModel.Endereco, transacao);
            conexao.Execute(sqlInserirEmail, colaboradorModel.Emails, transacao);
            conexao.Execute(sqlInserirTelefone, colaboradorModel.Telefones, transacao);

            return true;
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

        public static IList<ColaboradorModel> ListarColaborador(IDbConnection conexao)
        {
            var dicionarioColaborador = new Dictionary<int, ColaboradorModel>();

            conexao.Query<ColaboradorModel, EnderecoModel, ColaboradorModel>(
                sqlListarTodosOsColaboradores,
                (colaboradorModel, enderecoModel) =>
                MapearListagemDeColaborador(colaboradorModel, enderecoModel, dicionarioColaborador),
                splitOn: "split");

            conexao.Query<ColaboradorModel, EmailModel, ColaboradorModel>(
                EmailSql.ListarTodosPorId,
                (colaboradorModel, emailModel) => 
                MapearListagemDeEmailsDosColaboradores(colaboradorModel, emailModel, dicionarioColaborador),
                splitOn: "split");

            conexao.Query<ColaboradorModel, TelefoneModel, ColaboradorModel>(
                TelefoneSql.ListarTodosPorId,
                (colaboradorModel, telefoneModel) =>
                MapearListagemDeTelefonesDosClientes(colaboradorModel, telefoneModel, dicionarioColaborador),
                splitOn: "split");

            return dicionarioColaborador.Values.ToList();
        }

        

        private static ColaboradorModel MapearListagemDeColaborador(ColaboradorModel colaboradorModel, EnderecoModel enderecoModel, Dictionary<int, ColaboradorModel> dicionarioColaborador)
        {
            if (dicionarioColaborador.TryGetValue(colaboradorModel.IdUsuario, out var colaborador) && colaborador.Endereco.Id != enderecoModel.Id)
                colaborador.Endereco = enderecoModel;
            else
            {
                colaboradorModel.Endereco = enderecoModel;
                dicionarioColaborador.Add(colaboradorModel.IdUsuario, colaboradorModel);
            }

            return colaboradorModel;
        }

        private static ColaboradorModel MapearListagemDeEmailsDosColaboradores(ColaboradorModel colaboradorModel, EmailModel emailModel, Dictionary<int, ColaboradorModel> dicionarioColaborador)
        {
            if(dicionarioColaborador.TryGetValue(colaboradorModel.IdUsuario, out var colaborador))
                colaborador.Emails.Add(emailModel);

            return colaboradorModel;
        }

        private static ColaboradorModel MapearListagemDeTelefonesDosClientes(ColaboradorModel colaboradorModel, TelefoneModel telefoneModel, Dictionary<int, ColaboradorModel> dicionarioCliente)
        {
            if(dicionarioCliente.TryGetValue(colaboradorModel.IdUsuario, out var colaborador))
                colaborador.Telefones.Add(telefoneModel);

            return colaboradorModel;
        }

        public static bool RemoverColaborador(IDbConnection conexao, IDbTransaction transacao, int id)
        {
            conexao.Query("delete Colaborador where id_usuario = @id", new { id }, transacao);
            conexao.Query(EnderecoSql.Remover, new { id }, transacao);
            conexao.Query(EmailSql.Remover, new { id }, transacao);
            conexao.Query(TelefoneSql.Remover, new { id }, transacao);
            conexao.Query(UsuarioSql.Remover, new { id }, transacao);

            return true;
        }

        private static readonly string sqlAtualizarColaborador = 
            @"update Colaborador set
            salario = @Salario,
            comissao = @Comissao
            where id_usuario = @IdUsuario";

        public static bool AtualizarColaborador(IDbConnection conexao, IDbTransaction transacao, ColaboradorModel colaboradorModel)
        {
            conexao.Execute(UsuarioSql.Atualizar, colaboradorModel, transacao);
            conexao.Execute(sqlAtualizarColaborador, colaboradorModel, transacao);
            conexao.Execute(EnderecoSql.Atualizar(colaboradorModel.Endereco), colaboradorModel.Endereco, transacao);

            foreach (var email in colaboradorModel.Emails)
            {
                email.Nome = "123456789";
                conexao.Execute(EmailSql.Atualizar, email, transacao);
            }
            foreach (var telefone in colaboradorModel.Telefones)
            {
                telefone.Numero = "1234568";
                conexao.Execute(TelefoneSql.Atualizar, telefone, transacao);
            }

            return true;
        }
    }
}
