using CRUD___Adriano.Features.Relatório.Model;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CRUD___Adriano.Features.Relatório.Dao
{
    public class RelatorioVendaProdutoDao
    {
        private readonly IDbConnection _conexao;

        public RelatorioVendaProdutoDao(IDbConnection conexao)
        {
            _conexao = conexao;
        }

        public IList<RelatorioVendaProdutoModel> ListarProdutosPeloFiltro(FiltroRelatorioVendaProduto filtro)
        {
            try
            {
                _conexao.Open();
                return _conexao.Query<RelatorioVendaProdutoModel>(filtro.GerarSql(), filtro.RetornarParametroDinamico()).ToList();
            }
            finally
            {
                _conexao.Close();
            }
        }
    }
}
