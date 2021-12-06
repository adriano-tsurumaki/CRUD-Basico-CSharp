using CRUD___Adriano.Features.Relatório.Enum;
using CRUD___Adriano.Features.Relatório.Model;
using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.ValueObject.Precos;
using CRUD___Adriano.Features.Vendas.Sql;
using Dapper;
using System;
using System.Text;

namespace CRUD___Adriano.Features.Relatório.Dao
{
    public class FiltroRelatorioVendaCliente
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public int IdCliente { get; set; }
        public int LimiteQuantidadeCliente { get; set; }
        public ComparadorEnum TipoComparador{ get; set; }
        public Preco PrecoSelecionado { get; set; }
        public OrdernarClienteVendaEnum TipoOrdernar { get; set; }
        public bool OrdernarCrescente { get; set; }

        public string GerarSql()
        {
            var vendaAlias = "v";
            var usuarioAlias = "u";

            var select = new StringBuilder("select ");
            var from = new StringBuilder($"from Venda {vendaAlias} inner join Usuario {usuarioAlias} on {usuarioAlias}.id = {vendaAlias}.id_cliente");
            var where = new StringBuilder();
            var groupBy = new StringBuilder($"group by {usuarioAlias}.nome");
            var having = new StringBuilder("having ");
            var orderBy = new StringBuilder();

            if (LimiteQuantidadeCliente > 0)
                select.Append($"top {LimiteQuantidadeCliente} ");

            var precoBrutoTotal = $"sum({vendaAlias}.preco_bruto_total)";
            var descontoTotal = $"sum({vendaAlias}.desconto_total)";
            var precoLiquidoTotal = $"sum({vendaAlias}.preco_liquido_total)";

            select.Append($@"
                {usuarioAlias}.nome as {nameof(RelatorioVendaClienteModel.NomeCliente)},
                count(*) as {nameof(RelatorioVendaClienteModel.QuantidadeVendas)},
                {precoBrutoTotal} as {nameof(RelatorioVendaClienteModel.TotalBruto)},
                {descontoTotal} as {nameof(RelatorioVendaClienteModel.DescontoTotal)},
                {precoLiquidoTotal} as {nameof(RelatorioVendaClienteModel.TotalLiquido)}");

            if (!DateMinOuMax(DataInicio) && !DateMinOuMax(DataFinal))
                where.Append($"where {vendaAlias}.data_emissao between @DataInicio and @DataFinal");

            if (IdCliente != 0)
            {
                select.Append($", {usuarioAlias}.id");
                groupBy.Append($", {usuarioAlias}.id");
                having.Append($"{usuarioAlias}.id = @IdCliente and ");
            }

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

            if (TipoOrdernar == 0)
            {
                if (having.ToString() == "having ") having.Clear();
                else if (having.ToString()[(having.Length - 4)..] == "and ") having.Remove(having.Length - 5, 4);

                return $"{select} {from} {where} {groupBy} {having} {orderBy}";
            }

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

            orderBy.Append(OrdernarCrescente ? "asc" : "desc");

            if (having.ToString() == "having ") having.Clear();
            else if (having.ToString()[(having.Length - 4)..] == "and ") having.Remove(having.Length - 5, 4);

            return $"{select} {from} {where} {groupBy} {having} {orderBy}";
        }

        public DynamicParameters RetornarParametroDinamico()
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new
            {
                IdCliente,
                DataInicio = DataInicio.ZerarHorario(),
                DataFinal = DataFinal.ZerarHorario(),
                PrecoSelecionado = PrecoSelecionado.Valor,
                LimiteQuantidadeCliente,
            });

            return parametros;
        }

        public bool DateMinOuMax(DateTime dateTime) => dateTime == DateTime.MinValue || dateTime == DateTime.MaxValue;
    }
}
