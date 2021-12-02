using CRUD___Adriano.Features.ValueObject.Precos;

namespace CRUD___Adriano.Features.Relatório.Model
{
    public class RelatorioVendaProdutoModel
    {
        public int IdProduto { get; set; }
        public int IdCliente { get; set; }
        public string NomeProduto { get; set; }
        public string NomeCliente { get; set; }
        public int Quantidade { get; set; }
        public Preco PrecoBrutoTotal { get; set; }
        public Preco DescontoTotal { get; set; }
        public double LucroTotalPorcentagem { get; set; }
        public Preco LucroTotal { get; set; }
        public Preco PrecoLiquidoTotal { get; set; }
        public Preco PrecoTotalCusto { get; set; }
    }
}
