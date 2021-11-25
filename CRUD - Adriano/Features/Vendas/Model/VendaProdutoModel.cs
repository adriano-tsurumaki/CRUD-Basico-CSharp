using CRUD___Adriano.Features.ValueObject.Precos;

namespace CRUD___Adriano.Features.Vendas.Model
{
    public class VendaProdutoModel
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int IdVenda { get; set; }
        public string Nome { get; set; }
        public Preco Desconto { get; set; }
        public int Quantidade { get; set; }
        public Preco PrecoBruto { get; set; }
        public double Lucro { get; set; }
        public Preco PrecoVenda { get => PrecoBruto * (Lucro + 1); }

        public VendaProdutoModel()
        {
            Quantidade = 1;
        }

        public Preco PrecoLiquido { get => (PrecoVenda - Desconto) * Quantidade; }

        public static bool operator ==(VendaProdutoModel produtoModelA, VendaProdutoModel produtoModelB) => 
            produtoModelA.Id == produtoModelB.Id && produtoModelA.IdProduto == produtoModelB.IdProduto &&
            produtoModelA.IdVenda == produtoModelB.IdVenda && produtoModelA.Nome == produtoModelB.Nome &&
            produtoModelA.Desconto == produtoModelB.Desconto && produtoModelA.Quantidade == produtoModelB.Quantidade &&
            produtoModelA.PrecoBruto == produtoModelB.PrecoBruto && produtoModelA.Lucro == produtoModelB.Lucro;

        public static bool operator !=(VendaProdutoModel produtoModelA, VendaProdutoModel produtoModelB) =>
            produtoModelA.Id != produtoModelB.Id || produtoModelA.IdProduto != produtoModelB.IdProduto ||
            produtoModelA.IdVenda != produtoModelB.IdVenda || produtoModelA.Nome != produtoModelB.Nome ||
            produtoModelA.Desconto != produtoModelB.Desconto || produtoModelA.Quantidade != produtoModelB.Quantidade ||
            produtoModelA.PrecoBruto != produtoModelB.PrecoBruto || produtoModelA.Lucro != produtoModelB.Lucro;
    }
}
