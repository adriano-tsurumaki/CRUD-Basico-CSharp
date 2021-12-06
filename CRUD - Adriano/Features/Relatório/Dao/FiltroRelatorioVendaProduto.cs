using CRUD___Adriano.Features.Relatório.Model;
using CRUD___Adriano.Features.Utils;
using Dapper;
using System;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace CRUD___Adriano.Features.Relatório.Dao
{
    public class FiltroRelatorioVendaProduto
    {
        public int IdCliente { get; set; }
        public int IdProduto { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }

        private const string vendaProdutoAlias = "vp";
        private const string vendaAlias = "v";
        private const string usuarioAlias = "u";
        private const string produtoAlias = "p";

        private DynamicParameters _parametros;

        public FiltroRelatorioVendaProduto() =>
            _parametros = new DynamicParameters();

        public string GerarSql()
        {
            var select = new StringBuilder("select ");
            var from = new StringBuilder($"from VendaProduto {vendaProdutoAlias} ");
            var innerJoin = new StringBuilder();
            var where = new StringBuilder("where ");
            var groupBy = new StringBuilder($"group by {produtoAlias}.nome, {produtoAlias}.id");
            var having = new StringBuilder("having ");

            var lucroTotal = $"sum({vendaProdutoAlias}.preco_liquido - {vendaProdutoAlias}.preco_bruto * {vendaProdutoAlias}.quantidade)";
            var precoBrutoTotal = $"sum({vendaProdutoAlias}.preco_bruto * {vendaProdutoAlias}.quantidade)";

            select.Append($@"
                p.id as {nameof(RelatorioVendaProdutoModel.IdProduto)}, 
                p.nome as {nameof(RelatorioVendaProdutoModel.NomeProduto)},
                sum({vendaProdutoAlias}.quantidade) as {nameof(RelatorioVendaProdutoModel.Quantidade)},
                {precoBrutoTotal} as {nameof(RelatorioVendaProdutoModel.PrecoBrutoTotal)}, 
                sum({vendaProdutoAlias}.desconto * {vendaProdutoAlias}.quantidade) as {nameof(RelatorioVendaProdutoModel.DescontoTotal)},
                {lucroTotal} as {nameof(RelatorioVendaProdutoModel.LucroTotal)},
                {lucroTotal} / {precoBrutoTotal} * 100 as {nameof(RelatorioVendaProdutoModel.LucroTotalPorcentagem)}, 
                sum({vendaProdutoAlias}.preco_liquido) as {nameof(RelatorioVendaProdutoModel.PrecoLiquidoTotal)}");

            innerJoin.Append($"inner join Produto {produtoAlias} on {produtoAlias}.id = {vendaProdutoAlias}.id_produto ");

            if (IdCliente != 0 || (!DataInicio.DateMinOuMax() && !DataFinal.DateMinOuMax()))
                innerJoin.Append($@"inner join Venda {vendaAlias} on {vendaAlias}.id = {vendaProdutoAlias}.id_venda ");

            GerarFiltroPorCliente(select, innerJoin, groupBy, having);

            GerarFiltroPorProduto(having);

            GerarFiltroPorData(where);

            FormatarStringHaving(having);

            FormatarStringWhere(where);

            return $"{select} {from} {innerJoin} {where} {groupBy} {having}".RemoverExcessoDeEspaçoEmBranco();
        }

        private void GerarFiltroPorCliente(StringBuilder select, StringBuilder innerJoin, StringBuilder groupBy, StringBuilder having)
        {
            if (IdCliente != 0)
            {
                select.Append($", {usuarioAlias}.nome as {nameof(RelatorioVendaProdutoModel.NomeCliente)}, {usuarioAlias}.id as {nameof(RelatorioVendaProdutoModel.IdCliente)} ");
                innerJoin.Append($"inner join Usuario {usuarioAlias} on {usuarioAlias}.id = {vendaAlias}.id_cliente ");
                groupBy.Append($", {usuarioAlias}.id, {usuarioAlias}.nome ");
                having.Append($"{usuarioAlias}.id = @IdCliente and ");

                _parametros.Add($"@{nameof(IdCliente)}", IdCliente, DbType.Int32, ParameterDirection.Input);
            }
        }

        private void GerarFiltroPorProduto(StringBuilder having)
        {
            if (IdProduto != 0)
            {
                having.Append($"{produtoAlias}.id = @IdProduto ");

                _parametros.Add($"@{nameof(IdProduto)}", IdProduto, DbType.Int32, ParameterDirection.Input);
            }
        }

        private void GerarFiltroPorData(StringBuilder where)
        {
            if (!DataInicio.DateMinOuMax() && !DataFinal.DateMinOuMax())
            {
                where.AppendLine(@"v.data_emissao between @DataInicio and @DataFinal");

                _parametros.Add($"@{nameof(DataInicio)}", DataInicio.ZerarHorario(), DbType.DateTime, ParameterDirection.Input);
                _parametros.Add($"@{nameof(DataFinal)}", DataFinal.ZerarHorario(), DbType.DateTime, ParameterDirection.Input);
            }
        }

        public void FormatarStringHaving(StringBuilder having)
        {
            if (having.ToString() == "having ") having.Clear();
            else if (having.ToString()[(having.Length - 4)..] == "and ") having.Remove(having.Length - 5, 4);
        }

        public void FormatarStringWhere(StringBuilder where)
        {
            if (where.ToString() == "where ") where.Clear();
        }

        public DynamicParameters RetornarParametroDinamico() =>
            _parametros;
    }
}
