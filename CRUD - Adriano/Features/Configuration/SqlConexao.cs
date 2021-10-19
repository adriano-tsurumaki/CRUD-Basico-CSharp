using System.Data;
using System.Data.SqlClient;

namespace CRUD___Adriano.Features.Configuration
{
    public class SqlConexao
    {
        private static string stringConexao = @"Data Source=DESKTOP-29RP07U;Initial Catalog=DBCRUD_ADRIANO;Integrated Security=True";

        public static IDbConnection RetornarConexao() => new SqlConnection(stringConexao);
    }
}
