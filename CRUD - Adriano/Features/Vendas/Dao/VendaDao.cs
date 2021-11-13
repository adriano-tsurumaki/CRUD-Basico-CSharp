using System.Data;

namespace CRUD___Adriano.Features.Vendas.Dao
{
    public class VendaDao
    {
        private IDbConnection _conexao;

        public VendaDao(IDbConnection conexao)
        {
            _conexao = conexao;
        }
    }
}
