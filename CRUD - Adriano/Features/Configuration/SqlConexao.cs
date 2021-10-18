using System.Data;
using System.Data.SqlClient;

namespace CRUD___Adriano.Features.Configuration
{
    public class SqlConexao
    {
        private string stringConexao = @"";

        public IDbConnection RetornarConexao() => new SqlConnection(stringConexao);
    }
}
