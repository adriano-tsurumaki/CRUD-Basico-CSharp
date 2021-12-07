using CRUD___Adriano.Features.Relatório.Enum;
using CRUD___Adriano.Features.Relatório.Model;
using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.ValueObject.Precos;
using CRUD___Adriano.Features.Vendas.Sql;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CRUD___Adriano.Features.Relatório.Dao
{
    public class FiltroRelatorioVendaCliente
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public IList<int> ListaIdClientes{ get; set; }
        public int LimiteQuantidadeCliente { get; set; }
        public ComparadorEnum TipoComparador{ get; set; }
        public Preco PrecoSelecionado { get; set; }
        public OrdernarClienteVendaEnum TipoOrdernar { get; set; }
        public bool OrdernarCrescente { get; set; }

        private const string vendaAlias = "v";
        private const string usuarioAlias = "u";

        private DynamicParameters _parametros;

        public FiltroRelatorioVendaCliente()
        {
            ListaIdClientes = new List<int>();
            _parametros = new DynamicParameters();
        }

        public string GerarSql()
        {
            var select = new StringBuilder("select ");
            var from = new StringBuilder($"from Venda {vendaAlias} inner join Usuario {usuarioAlias} on {usuarioAlias}.id = {vendaAlias}.id_cliente");
            var where = new StringBuilder();
            var groupBy = new StringBuilder($"group by {usuarioAlias}.nome");
            var having = new StringBuilder("having ");
            var orderBy = new StringBuilder();

            GerarFiltroPorLimiteDeCliente(select);

            var precoBrutoTotal = $"sum({vendaAlias}.preco_bruto_total)";
            var descontoTotal = $"sum({vendaAlias}.desconto_total)";
            var precoLiquidoTotal = $"sum({vendaAlias}.preco_liquido_total)";

            select.Append($@"
                {usuarioAlias}.nome as {nameof(RelatorioVendaClienteModel.NomeCliente)},
                count(*) as {nameof(RelatorioVendaClienteModel.QuantidadeVendas)},
                {precoBrutoTotal} as {nameof(RelatorioVendaClienteModel.TotalBruto)},
                {descontoTotal} as {nameof(RelatorioVendaClienteModel.DescontoTotal)},
                {precoLiquidoTotal} as {nameof(RelatorioVendaClienteModel.TotalLiquido)}");
            
            GerarFiltroPorData(where);

            GerarFiltroPorCliente(select, groupBy, having);

            GerarFiltroPorComparacao(having, precoLiquidoTotal);

            if (TipoOrdernar == 0)
            {
                if (having.ToString() == "having ") having.Clear();
                else if (having.ToString()[(having.Length - 4)..] == "and ") having.Remove(having.Length - 5, 4);

                return $"{select} {from} {where} {groupBy} {having} {orderBy}";
            }

            GerarFiltroPorOrdenacao(orderBy, descontoTotal, precoBrutoTotal, precoLiquidoTotal);

            orderBy.Append(OrdernarCrescente ? "asc" : "desc");

            FormatarStringHaving(having);

            return $"{select} {from} {where} {groupBy} {having} {orderBy}";
        }

        private void GerarFiltroPorLimiteDeCliente(StringBuilder select)
        {
            if (LimiteQuantidadeCliente <= 0) return;

            select.Append($"top {LimiteQuantidadeCliente} ");
        }

        private void GerarFiltroPorData(StringBuilder where)
        {
            if (DataInicio.DateMinOuMax() || DataFinal.DateMinOuMax()) return;

            where.Append($"where {vendaAlias}.data_emissao between @DataInicio and @DataFinal");

            _parametros.Add($"@{nameof(DataInicio)}", DataInicio.ZerarHorario(), DbType.DateTime, ParameterDirection.Input);
            _parametros.Add($"@{nameof(DataFinal)}", DataFinal.ZerarHorario(), DbType.DateTime, ParameterDirection.Input);
        }

        private void GerarFiltroPorCliente(StringBuilder select, StringBuilder groupBy, StringBuilder having)
        {
            if (ListaIdClientes.Count == 0) return;

            select.Append($", {usuarioAlias}.id");
            groupBy.Append($", {usuarioAlias}.id");
            having.Append($"{usuarioAlias}.id in  @{nameof(ListaIdClientes)} and ");

            _parametros.Add($"@{nameof(ListaIdClientes)}", ListaIdClientes);
        }

        private void GerarFiltroPorComparacao(StringBuilder having, string precoLiquidoTotal)
        {
            if (TipoComparador == 0) return;

            switch (TipoComparador)
            {
                case ComparadorEnum.Igual:
                    having.Append($"{precoLiquidoTotal} = @PrecoSelecionado");
                    break;
                case ComparadorEnum.Diferente:
                    having.Append($"{precoLiquidoTotal} <> @PrecoSelecionado");
                    break;
                case ComparadorEnum.Maior:
                    having.Append($"{precoLiquidoTotal} > @PrecoSelecionado");
                    break;
                case ComparadorEnum.Menor:
                    having.Append($"{precoLiquidoTotal} < @PrecoSelecionado");
                    break;
            }

            _parametros.Add($"@{nameof(PrecoSelecionado)}", PrecoSelecionado.Valor, DbType.Double, ParameterDirection.Input);
        }

        private void GerarFiltroPorOrdenacao(StringBuilder orderBy, string descontoTotal, string precoBrutoTotal, string precoLiquidoTotal)
        {
            switch (TipoOrdernar)
            {
                case OrdernarClienteVendaEnum.Cliente:
                    orderBy.Append($"order by {usuarioAlias}.nome ");
                    break;
                case OrdernarClienteVendaEnum.Quantidade:
                    orderBy.Append($"order by count(*) ");
                    break;
                case OrdernarClienteVendaEnum.TotalDesconto:
                    orderBy.Append($"order by {descontoTotal} ");
                    break;
                case OrdernarClienteVendaEnum.TotalBruto:
                    orderBy.Append($"order by {precoBrutoTotal} ");
                    break;
                case OrdernarClienteVendaEnum.TotalLiquido:
                    orderBy.Append($"order by {precoLiquidoTotal} ");
                    break;
            }
        }

        private void FormatarStringHaving(StringBuilder having)
        {
            if (having.ToString() == "having ") having.Clear();
            else if (having.ToString()[(having.Length - 4)..] == "and ") having.Remove(having.Length - 5, 4);
        }

        public DynamicParameters RetornarParametroDinamico() =>
            _parametros;
    }
}
