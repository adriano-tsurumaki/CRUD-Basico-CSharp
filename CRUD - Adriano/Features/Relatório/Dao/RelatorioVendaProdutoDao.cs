using System.Data;

namespace CRUD___Adriano.Features.Relatório.Dao
{
    public class RelatorioVendaProdutoDao
    {
        private readonly IDbConnection _conexao;

        public RelatorioVendaProdutoDao(IDbConnection conexao)
        {
            _conexao = conexao;
        }
    }
}
