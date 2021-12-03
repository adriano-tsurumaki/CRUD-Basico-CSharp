using CRUD___Adriano.Features.Relatório.Model;
using CRUD___Adriano.Features.Utils;
using Dapper;
using System;
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

        public string GerarSql()
        {
            var vendaProdutoAlias = "vp";
            var vendaAlias = "v";
            var usuarioAlias = "u";
            var produtoAlias = 'p';

            var select = new StringBuilder("select ");
            var from = new StringBuilder($"from VendaProduto {vendaProdutoAlias}");
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

            innerJoin.AppendLine($"inner join Produto {produtoAlias} on {produtoAlias}.id = {vendaProdutoAlias}.id_produto");

            if (IdCliente != 0 || (!DateMinOuMax(DataInicio) && !DateMinOuMax(DataFinal)))
                innerJoin.AppendLine($@" inner join Venda {vendaAlias} on {vendaAlias}.id = {vendaProdutoAlias}.id_venda");

            if (IdCliente != 0)
            {
                select.AppendLine($", {usuarioAlias}.nome as {nameof(RelatorioVendaProdutoModel.NomeCliente)}, {usuarioAlias}.id as {nameof(RelatorioVendaProdutoModel.IdCliente)}");
                innerJoin.AppendLine($"inner join Usuario {usuarioAlias} on {usuarioAlias}.id = {vendaAlias}.id_cliente");
                groupBy.AppendLine($", {usuarioAlias}.id, {usuarioAlias}.nome");
                having.AppendLine($"{usuarioAlias}.id = @IdCliente and ");
            }

            if (IdProduto != 0)
                having.AppendLine($"{produtoAlias}.id = @IdProduto");

            if (!DateMinOuMax(DataInicio) && !DateMinOuMax(DataFinal))
                where.AppendLine(@"v.data_emissao between @DataInicio and @DataFinal");

            if (having.ToString() == "having ") having.Clear();
            else if (having.ToString()[(having.Length - 6)..] == "and \r\n") having.Remove(having.Length - 7, 4);


            if (where.ToString() == "where ") where.Clear();

            var sql = new StringBuilder();

            sql.AppendLine(select.ToString());
            sql.AppendLine(from.ToString());
            sql.AppendLine(innerJoin.ToString());
            sql.AppendLine(where.ToString());
            sql.AppendLine(groupBy.ToString());
            sql.AppendLine(having.ToString());

            return new Regex(@"\s\s+").Replace(sql.ToString(), " ");
        }

        public bool DateMinOuMax(DateTime dateTime) => dateTime == DateTime.MinValue || dateTime == DateTime.MaxValue;

        public DynamicParameters RetornarParametroDinamico()
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new
            {
                IdProduto,
                IdCliente,
                DataInicio = DataInicio.ZerarHorario(),
                DataFinal = DataFinal.ZerarHorario()
            });

            return parametros;
        }
    }
}
