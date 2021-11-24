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
    }
}
