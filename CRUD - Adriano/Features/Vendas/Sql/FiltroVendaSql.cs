using CRUD___Adriano.Features.ValueObject.Precos;
using System;
using System.Text;

namespace CRUD___Adriano.Features.Vendas.Sql
{
    public class FiltroVendaSql
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public ComparadorEnum TipoComparador { get; set; }
        public Preco ValorVenda { get; set; }

        public string GerarSql()
        {
            var sql = new StringBuilder(" where ");

            if (!DateMinOuMax(DataInicio) && !DateMinOuMax(DataFinal))
                sql.Append("data_emissao between @DataInicio and @DataFinal and");

            if (TipoComparador == 0) return sql.Remove(sql.Length - 4, 4).ToString();

            switch (TipoComparador)
            {
                case ComparadorEnum.Igual:
                    sql.Append("preco_liquido_total = @ValorVenda");
                    break;
                case ComparadorEnum.Maior:
                    sql.Append("preco_liquido_total > @ValorVenda");
                    break;
                case ComparadorEnum.Menor:
                    sql.Append("preco_liquido_total < @ValorVenda");
                    break;
                case ComparadorEnum.Diferente:
                    sql.Append("preco_liquido_total <> @ValorVenda");
                    break;
            }

            return sql.ToString();
        }

        public bool DateMinOuMax(DateTime dateTime) => dateTime == DateTime.MaxValue || dateTime == DateTime.MaxValue;
    }
}
