using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.Colaborador.Sql;
using CRUD___Adriano.Features.Entidades.DadosBancarios.Model;
using CRUD___Adriano.Features.Entidades.DadosBancarios.Sql;
using CRUD___Adriano.Features.Entidades.Email.Model;
using CRUD___Adriano.Features.Entidades.Email.Sql;
using CRUD___Adriano.Features.Entidades.Endereco.Model;
using CRUD___Adriano.Features.Entidades.Endereco.Sql;
using CRUD___Adriano.Features.Entidades.Telefone.Model;
using CRUD___Adriano.Features.Entidades.Telefone.Sql;
using CRUD___Adriano.Features.Usuario.Sql;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CRUD___Adriano.Features.Colaborador.Dao
{
    public class ColaboradorDao
    {
        private static readonly string sqlListarTodosOsColaboradores =
            @"select u.id as IdUsuario, u.nome, u.sobrenome, u.sexo, u.cpf, u.data_nascimento as DataNascimento, c.salario, c.comissao,
            c.id as split, en.id_usuario as IdUsuario, en.cep, en.logradouro, en.bairro, en.cidade, en.uf, en.complemento, en.numero
			from Colaborador c
			inner join Usuario u on u.id = c.id_usuario
			inner join Endereco en on en.id_usuario = u.id";

        private static readonly string sqlListarTodosOsDadosBancariosDosColaboradores =
            @"select u.id as IdUsuario, 
            u.id as split, db.agencia, db.conta, db.tipo_conta as TipoConta, db.banco
            from Colaborador c
            inner join Usuario u on u.id = c.id_usuario
            inner join DadosBancarios db on db.id_colaborador = c.id";

        public static bool CadastrarColaborador(IDbConnection conexao, IDbTransaction transacao, ColaboradorModel colaboradorModel)
        {
            colaboradorModel.IdUsuario = (int)conexao.ExecuteScalar(UsuarioSql.Inserir, colaboradorModel, transacao);

            colaboradorModel.DadosBancarios.IdColaborador = (int)conexao.ExecuteScalar(ColaboradorSql.Inserir, colaboradorModel, transacao);

            colaboradorModel.Endereco.IdUsuario = colaboradorModel.IdUsuario;

            foreach (var email in colaboradorModel.Emails)
                email.IdUsuario = colaboradorModel.IdUsuario;

            foreach (var telefone in colaboradorModel.Telefones)
                telefone.IdUsuario = colaboradorModel.IdUsuario;

            conexao.Execute(EnderecoSql.Inserir(colaboradorModel.Endereco), colaboradorModel.Endereco, transacao);
            conexao.Execute(EmailSql.Inserir, colaboradorModel.Emails, transacao);
            conexao.Execute(TelefoneSql.Inserir, colaboradorModel.Telefones, transacao);
            conexao.Execute(DadosBancariosSql.Inserir, colaboradorModel.DadosBancarios, transacao);

            return true;
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
                EmailSql.ListarTodos,
                (colaboradorModel, emailModel) => 
                MapearListagemDeEmailsDosColaboradores(colaboradorModel, emailModel, dicionarioColaborador),
                splitOn: "split");

            conexao.Query<ColaboradorModel, TelefoneModel, ColaboradorModel>(
                TelefoneSql.ListarTodos,
                (colaboradorModel, telefoneModel) =>
                MapearListagemDeTelefonesDosColaboradores(colaboradorModel, telefoneModel, dicionarioColaborador),
                splitOn: "split");

            conexao.Query<ColaboradorModel, DadosBancariosModel, ColaboradorModel>(
                sqlListarTodosOsDadosBancariosDosColaboradores,
                (colaboradorModel, dadosBancariosModel) => 
                MapearListagemDeDadosBancariosDosColaboradores(colaboradorModel, dadosBancariosModel, dicionarioColaborador),
                splitOn: "split");

            return dicionarioColaborador.Values.ToList();
        }

        public static ColaboradorModel MapearListagemDeColaborador(ColaboradorModel colaboradorModel, EnderecoModel enderecoModel, Dictionary<int, ColaboradorModel> dicionarioColaborador)
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

        public static ColaboradorModel MapearListagemDeEmailsDosColaboradores(ColaboradorModel colaboradorModel, EmailModel emailModel, Dictionary<int, ColaboradorModel> dicionarioColaborador)
        {
            if(dicionarioColaborador.TryGetValue(colaboradorModel.IdUsuario, out var colaborador))
                colaborador.Emails.Add(emailModel);

            return colaboradorModel;
        }

        public static ColaboradorModel MapearListagemDeTelefonesDosColaboradores(ColaboradorModel colaboradorModel, TelefoneModel telefoneModel, Dictionary<int, ColaboradorModel> dicionarioColaborador)
        {
            if(dicionarioColaborador.TryGetValue(colaboradorModel.IdUsuario, out var colaborador))
                colaborador.Telefones.Add(telefoneModel);

            return colaboradorModel;
        }

        private static ColaboradorModel MapearListagemDeDadosBancariosDosColaboradores(ColaboradorModel colaboradorModel, DadosBancariosModel dadosBancariosModel, Dictionary<int, ColaboradorModel> dicionarioColaborador)
        {
            if (dicionarioColaborador.TryGetValue(colaboradorModel.IdUsuario, out var colaborador))
                colaborador.DadosBancarios = dadosBancariosModel;

            return colaboradorModel;
        }

        public static IList<ColaboradorModel> ListarTodosOsColaboradoresSomenteIdENome(IDbConnection conexao) =>
            conexao.Query<ColaboradorModel>(ColaboradorSql.ListarTodosComCamposSomenteIdENome).ToList();

        public static IList<ColaboradorModel> ListarPelaQuantidadeSomenteIdENome(IDbConnection conexao, int quantidade) =>
            conexao.Query<ColaboradorModel>(ColaboradorSql.ListarPelaQuantidadeComCamposSomenteIdENome, new { quantidade }).ToList();

        public static IList<ColaboradorModel> ListarColaboradoresPeloNomeSomenteIdENome(IDbConnection conexao, string nome) =>
            conexao.Query<ColaboradorModel>(ColaboradorSql.ListarPeloNomeComCamposSomenteIdENome, new { nome }).ToList();

        public static ColaboradorModel SelecionarColaborador(IDbConnection conexao, int id)
        {
            var colaborador = conexao.QuerySingleOrDefault<ColaboradorModel>(ColaboradorSql.Selecionar, new { id });

            colaborador.DadosBancarios = conexao.QuerySingleOrDefault<DadosBancariosModel>(DadosBancariosSql.SelecionarUm, new { id });
            colaborador.Endereco = conexao.QuerySingleOrDefault<EnderecoModel>(EnderecoSql.SelecionarUm, new { id });
            colaborador.Emails = conexao.Query<EmailModel>(EmailSql.ListarTodosPorId, new { id }).ToList();
            colaborador.Telefones = conexao.Query<TelefoneModel>(TelefoneSql.ListarTodosPorId, new { id }).ToList();

            return colaborador;
        }

        public static ColaboradorModel SelecionarColaboradorSomenteIdENome(IDbConnection conexao, int id) =>
            conexao.QuerySingleOrDefault<ColaboradorModel>(ColaboradorSql.SelecionarComCamposSomenteIdENome, new { id });

        public static bool RemoverColaborador(IDbConnection conexao, IDbTransaction transacao, int id)
        {
            conexao.Query(EnderecoSql.Remover, new { id }, transacao);
            conexao.Query(EmailSql.Remover, new { id }, transacao);
            conexao.Query(TelefoneSql.Remover, new { id }, transacao);
            var idColaborador = conexao.Query<int>("select id from Colaborador where id_usuario = @id", new { id }, transacao).First();
            conexao.Query("delete DadosBancarios where id_colaborador = @idColaborador", new { idColaborador }, transacao);
            conexao.Query("delete Colaborador where id_usuario = @id", new { id }, transacao);
            conexao.Query(UsuarioSql.Remover, new { id }, transacao);

            return true;
        }

        private static readonly string sqlAtualizarColaborador = 
            @"update Colaborador set
            salario = @Salario,
            comissao = @Comissao
            where id_usuario = @IdUsuario";

        private static readonly string sqlAtualizarDadosBancarios =
            @"update DadosBancarios set
            agencia = @Agencia,
            conta = @Conta,
            tipo_conta = @TipoConta,
            banco = @Banco
            where id_colaborador = @IdColaborador";

        public static bool AtualizarColaborador(IDbConnection conexao, IDbTransaction transacao, ColaboradorModel colaboradorModel)
        {
            conexao.Execute(UsuarioSql.Atualizar, colaboradorModel, transacao);
            conexao.Execute(sqlAtualizarColaborador, colaboradorModel, transacao);
            conexao.Execute(EnderecoSql.Atualizar(colaboradorModel.Endereco), colaboradorModel.Endereco, transacao);
            conexao.Execute(sqlAtualizarDadosBancarios, colaboradorModel.DadosBancarios, transacao);

            foreach (var email in colaboradorModel.Emails)
            {
                if (email.Id > 0)
                    conexao.Execute(EmailSql.Atualizar, email, transacao);
                else
                {
                    email.IdUsuario = colaboradorModel.IdUsuario;
                    conexao.Execute(EmailSql.Inserir, email, transacao);
                }
            }
            foreach (var telefone in colaboradorModel.Telefones)
            {
                if (telefone.Id > 0)
                    conexao.Execute(TelefoneSql.Atualizar, telefone, transacao);
                else
                {
                    telefone.IdUsuario = colaboradorModel.IdUsuario;
                    conexao.Execute(TelefoneSql.Inserir, telefone, transacao);
                }
            }

            return true;
        }
    }
}
