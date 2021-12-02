using CRUD___Adriano.Features.Relatório.Dao;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace Teste_Unitário.Sql
{
    [TestClass]
    public class FiltroRelatorioVendaProdutoDeveria
    {
        //[DataTestMethod]
        //[DynamicData(nameof(Lista_para_gerar_sql), DynamicDataSourceType.Method)]
        [TestMethod]
        public void Deveria_gerar_sql_filtrado_corretamente()
        {
            var filtro = new FiltroRelatorioVendaProduto();

            filtro.IdCliente = 1;
            filtro.IdProduto = 1;
            var sql = filtro.GerarSql();
            Debug.WriteLine(sql);
        }

        public static IEnumerable<object[]> Lista_para_gerar_sql() =>
            new List<object[]>
            {
                new object[]
                {

                }
            };
    }
}
