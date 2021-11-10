using CRUD___Adriano.Features.Fornecedor.Model;
using System.Text;

namespace CRUD___Adriano.Features.Fornecedor.Sql
{
    public static class FornecedorSql
    {
        public static string InserirFornecedor(FornecedorModel fornecedorModel)
        {
            var insertSql = new StringBuilder("insert into Fornecedor(id_usuario");
            var valuesSql = new StringBuilder("values (@IdUsuario");

            if (!string.IsNullOrEmpty(fornecedorModel.Observacao))
            {
                insertSql.Append(", observacao");
                valuesSql.Append(", @Observacao");
            }

            insertSql.Append(")");
            valuesSql.Append(")");
            return string.Join(' ', insertSql, valuesSql);
        }
    }
}
