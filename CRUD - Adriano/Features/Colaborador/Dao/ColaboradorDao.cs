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
        public static readonly string sqlListarTodosOsDadosBancariosDosColaboradores =
            @"select u.id as IdUsuario, 
            u.id as split, db.agencia, db.conta, db.tipo_conta as TipoConta, db.banco
            from Colaborador c
            inner join Usuario u on u.id = c.id_usuario
            inner join DadosBancarios db on db.id_colaborador = c.id";

        public static readonly string sqlAtualizarDadosBancarios =
            @"update DadosBancarios set
            agencia = @Agencia,
            conta = @Conta,
            tipo_conta = @TipoConta,
            banco = @Banco
            where id_colaborador = @IdColaborador";

        private IDbConnection _conexao;

        public ColaboradorDao(IDbConnection conexao)
        {
            _conexao = conexao;
        }

        public bool CadastrarColaborador(ColaboradorModel colaboradorModel)
        {
            try
            {
                _conexao.Open();
                using var transacao = _conexao.BeginTransaction();
                colaboradorModel.IdUsuario = (int)_conexao.ExecuteScalar(UsuarioSql.Inserir, UsuarioSql.RetornarParametroDinamicoDaModel(colaboradorModel), transacao);

                colaboradorModel.DadosBancarios.IdColaborador = (int)_conexao.ExecuteScalar(ColaboradorSql.Inserir, colaboradorModel, transacao);

                colaboradorModel.Endereco.IdUsuario = colaboradorModel.IdUsuario;

                foreach (var email in colaboradorModel.Emails)
                    email.IdUsuario = colaboradorModel.IdUsuario;

                foreach (var telefone in colaboradorModel.Telefones)
                    telefone.IdUsuario = colaboradorModel.IdUsuario;

                _conexao.Execute(EnderecoSql.Inserir(colaboradorModel.Endereco), colaboradorModel.Endereco, transacao);
                _conexao.Execute(EmailSql.Inserir, colaboradorModel.Emails, transacao);
                _conexao.Execute(TelefoneSql.Inserir, colaboradorModel.Telefones, transacao);
                _conexao.Execute(DadosBancariosSql.Inserir, colaboradorModel.DadosBancarios, transacao);
                
                transacao.Commit();
                return true;
            }
            finally
            {
                _conexao.Close();
            }
            
        }

        public IList<ColaboradorModel> ListarColaborador()
        {
            try
            {
                _conexao.Open();
                var dicionarioColaborador = new Dictionary<int, ColaboradorModel>();

                _conexao.Query<ColaboradorModel, EnderecoModel, ColaboradorModel>(
                    ColaboradorSql.ListarTodos,
                    (colaboradorModel, enderecoModel) =>
                    MapearListagemDeColaborador(colaboradorModel, enderecoModel, dicionarioColaborador),
                    splitOn: "split");

                _conexao.Query<ColaboradorModel, EmailModel, ColaboradorModel>(
                    EmailSql.ListarTodos,
                    (colaboradorModel, emailModel) =>
                    MapearListagemDeEmailsDosColaboradores(colaboradorModel, emailModel, dicionarioColaborador),
                    splitOn: "split");

                _conexao.Query<ColaboradorModel, TelefoneModel, ColaboradorModel>(
                    TelefoneSql.ListarTodos,
                    (colaboradorModel, telefoneModel) =>
                    MapearListagemDeTelefonesDosColaboradores(colaboradorModel, telefoneModel, dicionarioColaborador),
                    splitOn: "split");

                _conexao.Query<ColaboradorModel, DadosBancariosModel, ColaboradorModel>(
                    sqlListarTodosOsDadosBancariosDosColaboradores,
                    (colaboradorModel, dadosBancariosModel) =>
                    MapearListagemDeDadosBancariosDosColaboradores(colaboradorModel, dadosBancariosModel, dicionarioColaborador),
                    splitOn: "split");

                return dicionarioColaborador.Values.ToList();
            }
            finally
            {
                _conexao.Close();
            }
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

        public IList<ColaboradorModel> ListarTodosOsColaboradoresSomenteIdENome() =>
            _conexao.Query<ColaboradorModel>(ColaboradorSql.ListarTodosComCamposSomenteIdENome).ToList();

        public IList<ColaboradorModel> ListarPelaQuantidadeSomenteIdENome(int quantidade) =>
            _conexao.Query<ColaboradorModel>(ColaboradorSql.ListarPelaQuantidadeComCamposSomenteIdENome, new { quantidade }).ToList();

        public IList<ColaboradorModel> ListarColaboradoresPeloNomeSomenteIdENome(string nome) =>
            _conexao.Query<ColaboradorModel>(ColaboradorSql.ListarPeloNomeComCamposSomenteIdENome, new { nome }).ToList();

        public ColaboradorModel SelecionarColaborador(int id)
        {
            var colaborador = _conexao.QuerySingleOrDefault<ColaboradorModel>(ColaboradorSql.Selecionar, new { id });

            colaborador.DadosBancarios = _conexao.QuerySingleOrDefault<DadosBancariosModel>(DadosBancariosSql.SelecionarUm, new { id });
            colaborador.Endereco = _conexao.QuerySingleOrDefault<EnderecoModel>(EnderecoSql.SelecionarUm, new { id });
            colaborador.Emails = _conexao.Query<EmailModel>(EmailSql.ListarTodosPorId, new { id }).ToList();
            colaborador.Telefones = _conexao.Query<TelefoneModel>(TelefoneSql.ListarTodosPorId, new { id }).ToList();

            return colaborador;
        }

        public ColaboradorModel SelecionarColaboradorSomenteIdENome(int id) =>
            _conexao.QuerySingleOrDefault<ColaboradorModel>(ColaboradorSql.SelecionarComCamposSomenteIdENome, new { id });

        public int SelecionarQuantidadeDeTodosOsColaboradores() =>
            _conexao.QuerySingleOrDefault<int>(ColaboradorSql.SelecionarQuantidadeDeTodos);

        public bool RemoverColaborador(int id)
        {
            try
            {
                _conexao.Open();
                using var transacao = _conexao.BeginTransaction();

                _conexao.Query(EnderecoSql.Remover, new { id }, transacao);
                _conexao.Query(EmailSql.Remover, new { id }, transacao);
                _conexao.Query(TelefoneSql.Remover, new { id }, transacao);

                var idColaborador = _conexao.Query<int>("select id from Colaborador where id_usuario = @id", new { id }, transacao).First();

                _conexao.Query("delete DadosBancarios where id_colaborador = @idColaborador", new { idColaborador }, transacao);
                _conexao.Query("delete Colaborador where id_usuario = @id", new { id }, transacao);
                _conexao.Query(UsuarioSql.Remover, new { id }, transacao);

                transacao.Commit();
                return true;
            }
            finally
            {
                _conexao.Close();
            }

        }

        public bool AtualizarColaborador(ColaboradorModel colaboradorModel)
        {
            try
            {
                _conexao.Open();
                using var transacao = _conexao.BeginTransaction();

                _conexao.Execute(UsuarioSql.Atualizar, UsuarioSql.RetornarParametroDinamicoDaModel(colaboradorModel), transacao);
                _conexao.Execute(ColaboradorSql.Atualizar, colaboradorModel, transacao);
                _conexao.Execute(EnderecoSql.Atualizar(colaboradorModel.Endereco), colaboradorModel.Endereco, transacao);
                _conexao.Execute(sqlAtualizarDadosBancarios, colaboradorModel.DadosBancarios, transacao);

                foreach (var email in colaboradorModel.Emails)
                {
                    if (email.Id > 0)
                        _conexao.Execute(EmailSql.Atualizar, email, transacao);
                    else
                    {
                        email.IdUsuario = colaboradorModel.IdUsuario;
                        _conexao.Execute(EmailSql.Inserir, email, transacao);
                    }
                }
                foreach (var telefone in colaboradorModel.Telefones)
                {
                    if (telefone.Id > 0)
                        _conexao.Execute(TelefoneSql.Atualizar, telefone, transacao);
                    else
                    {
                        telefone.IdUsuario = colaboradorModel.IdUsuario;
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
    }
}
