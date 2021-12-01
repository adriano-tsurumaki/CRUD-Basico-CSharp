using CRUD___Adriano.Features.ValueObject.Precos;

namespace CRUD___Adriano.Features.Relatório.Model
{
    public class RelatorioVendaProdutoModel
    {
        public string NomeProduto { get; set; }
        public int QuantidadeProdutos { get; set; }
        public Preco PrecoBrutoTotal { get; set; }
        public Preco DescontoTotal { get; set; }
        public Preco PrecoLiquidoTotal { get; set; }
        public Preco PrecoTotalCusto { get; set; }
        public double Lucro { get; set; }
    }
}
