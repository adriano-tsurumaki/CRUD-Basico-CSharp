using CRUD___Adriano.Features.Entidades.Email.Sql;
using CRUD___Adriano.Features.Entidades.Endereco.Sql;
using CRUD___Adriano.Features.Entidades.Telefone.Sql;
using CRUD___Adriano.Features.Fornecedor.Model;
using CRUD___Adriano.Features.Fornecedor.Sql;
using CRUD___Adriano.Features.Usuario.Sql;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CRUD___Adriano.Features.Fornecedor.Dao
{
    public class FornecedorDao
    {
        private readonly IDbConnection _conexao;

        public FornecedorDao(IDbConnection conexao)
        {
            _conexao = conexao;
        }

        public bool CadastrarFornecedor(FornecedorModel fornecedorModel)
        {
            try
            {
                _conexao.Open();
                using var transacao = _conexao.BeginTransaction();

                fornecedorModel.IdUsuario = (int)_conexao.ExecuteScalar(UsuarioSql.Inserir, UsuarioSql.RetornarParametroDinamicoParaInserirUm(fornecedorModel), transacao);

                _conexao.Execute(FornecedorSql.InserirFornecedor(fornecedorModel), FornecedorSql.RetornarParametroDinamicoParaInserirUm(fornecedorModel), transacao);

                fornecedorModel.Endereco.IdUsuario = fornecedorModel.IdUsuario;

                foreach (var email in fornecedorModel.Emails)
                    email.IdUsuario = fornecedorModel.IdUsuario;

                foreach (var telefone in fornecedorModel.Telefones)
                    telefone.IdUsuario = fornecedorModel.IdUsuario;

                _conexao.Execute(EnderecoSql.Inserir(fornecedorModel.Endereco), fornecedorModel.Endereco, transacao);
                _conexao.Execute(EmailSql.Inserir, fornecedorModel.Emails, transacao);
                _conexao.Execute(TelefoneSql.Inserir, fornecedorModel.Telefones, transacao);

                transacao.Commit();
                return true;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public IList<FornecedorModel> ListarTodosOsFornecedoresSomenteIdENome() =>
            _conexao.Query<FornecedorModel>(FornecedorSql.ListarTodosComCamposSomenteIdENome).ToList();

        public IList<FornecedorModel> ListarPelaQuantidadeSomenteIdENome(int quantidade) =>
            _conexao.Query<FornecedorModel>(FornecedorSql.ListarPelaQuantidadeComCamposSomenteIdENome, new { quantidade }).ToList();

        public IList<FornecedorModel> ListarFornecedoresPeloNomeSomenteIdENome(string nome) =>
            _conexao.Query<FornecedorModel>(FornecedorSql.ListarPeloNomeComCamposSomenteIdENome, new { nome }).ToList();

        public FornecedorModel SelecionarClienteSomenteIdENome(int id) =>
           _conexao.QuerySingleOrDefault<FornecedorModel>(FornecedorSql.SelecionarComCamposSomenteIdENome, new { id });
    }
}
