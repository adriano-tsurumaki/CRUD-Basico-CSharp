using CRUD___Adriano.Features.Fornecedor.Model;

namespace CRUD___Adriano.Features.Produto.Model
{
    public class ProdutoModel
    {
        public FornecedorModel Fornecedor { get; set; }
        public int Id { get; set; }
        public string CodigoBarras { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public float PrecoBruto { get; set; }
        public float Lucro { get; set; }
        public int Quantidade { get; set; }

        public ProdutoModel()
        {
            Fornecedor = new FornecedorModel();
        }
    }
}
