using CRUD___Adriano.Features.Fornecedor.Model;
using CRUD___Adriano.Features.ValueObject.Porcentagens;
using CRUD___Adriano.Features.ValueObject.Precos;

namespace CRUD___Adriano.Features.Produto.Model
{
    public class ProdutoModel
    {
        public FornecedorModel Fornecedor { get; set; }
        public int Id { get; set; }
        public string CodigoBarras { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public Preco PrecoBruto { get; set; }
        public Porcentagem Lucro { get; set; }
        public int Quantidade { get; set; }

        public ProdutoModel()
        {
            Fornecedor = new FornecedorModel();
        }
    }
}
