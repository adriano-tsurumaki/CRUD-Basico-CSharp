using CRUD___Adriano.Features.Produto.Model;
using CRUD___Adriano.Features.Produto.Sql;
using Dapper;
using System.Data;

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
    }
}
