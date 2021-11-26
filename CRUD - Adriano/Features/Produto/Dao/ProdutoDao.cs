using CRUD___Adriano.Features.Fornecedor.Model;
using CRUD___Adriano.Features.Produto.Model;
using CRUD___Adriano.Features.Produto.Sql;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CRUD___Adriano.Features.Produto.Dao
{
    public class ProdutoDao
    {
        private readonly IDbConnection _conexao;

        public ProdutoDao(IDbConnection conexao)
        {
            _conexao = conexao;
        }

        public bool CadastrarProduto(ProdutoModel produtoModel)
        {
            try
            {
                _conexao.Open();
                _conexao.Execute(ProdutoSql.Inserir, ProdutoSql.RetornarParametroDinamicoParaInserirUm(produtoModel));
                return true;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public bool AtualizarProduto(ProdutoModel produtoModel)
        {
            try
            {
                _conexao.Open();

                _conexao.Execute(ProdutoSql.Atualizar, ProdutoSql.RetornarParametroDinamicoParaInserirUm(produtoModel));
                
                return true;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public IList<ProdutoModel> ListarTodosOsProdutos()
        {
            try
            {
                _conexao.Open();

                return _conexao.Query<ProdutoModel>(ProdutoSql.ListarTodos).ToList();
            }
            finally
            {
                _conexao.Close();
            }
        }

        public IList<ProdutoModel> ListarTodosOsProdutosSomenteIdENome()
        {
            try
            {
                _conexao.Open();

                return _conexao.Query<ProdutoModel>(ProdutoSql.ListarTodosComCamposSomenteIdENome).ToList();
            }
            finally
            {
                _conexao.Close();
            }
        }

        public IList<ProdutoModel> ListarProdutosPeloNomeSomenteIdENome(string nome)
        {
            try
            {
                _conexao.Open();

                return _conexao.Query<ProdutoModel>(ProdutoSql.ListarPeloNomeComCamposSomenteIdENome, new { nome }).ToList();
            }
            finally
            {
                _conexao.Close();
            }
        }

        public IList<ProdutoModel> ListarPelaQuantidadeSomenteIdENome(int quantidade)
        {
            try
            {
                _conexao.Open();

                return _conexao.Query<ProdutoModel>(ProdutoSql.ListarPelaQuantidadeComCamposSomenteIdENome, new { quantidade }).ToList();
            }
            finally
            {
                _conexao.Close();
            }
        }

        public bool InativarProduto(int id)
        {
            try
            {
                _conexao.Open();

                _conexao.Query("update Produto set ativo = 0 where id = @Id", new { id });

                return true;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public ProdutoModel SelecionarProduto(int id)
        {
            var produtoModel = _conexao.QuerySingleOrDefault<ProdutoModel>(ProdutoSql.Selecionar, new { id });
            produtoModel.Fornecedor = _conexao.QuerySingleOrDefault<FornecedorModel>(@"select f.id, u.nome from Fornecedor f
	        inner join Usuario u on u.id = f.id_usuario
	        inner join Produto p on p.id_fornecedor = f.id
	        where p.id = @id;", new { id });
            return produtoModel;
        }

        public ProdutoModel SelecionarProdutoSomenteIdENome(int id) =>
            _conexao.QuerySingleOrDefault<ProdutoModel>(ProdutoSql.SelecionarComCamposSomenteIdENome, new { id });
    }
}
