using CRUD___Adriano.Features.ValueObject.Precos;
using CRUD___Adriano.Features.Vendas.Dao;
using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System.ComponentModel;
using System.Linq;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class CarrinhoVendaController
    {
        private readonly VendaDao _vendaDao;
        private readonly UcCarrinhoVenda _ucCarrinhoVenda;
        private BindingList<VendaProdutoModel> _vendaProdutosBinding;
        private VendaProdutoModel _produtoSelecionadoParaDesconto;

        public CarrinhoVendaController(VendaDao vendaDao)
        {
            _vendaDao = vendaDao;
            _vendaProdutosBinding = new BindingList<VendaProdutoModel>();
            _ucCarrinhoVenda = new UcCarrinhoVenda(this);
            AdicionarModel();
        }

        public void AdicionarModel() => _ucCarrinhoVenda.BindModel(_vendaProdutosBinding);

        public void AdicionarProdutoNoCarrinho(VendaProdutoModel vendaProdutoModel)
        {
            _vendaProdutosBinding.Add(vendaProdutoModel);
            AtualizarSubTotal();
        }

        public void AtualizarSubTotal()
        {
            var quantidadeTotal = RetornarQuantidadeTotal();
            _ucCarrinhoVenda.lblSubTotal.Text = $"SubTotal ({quantidadeTotal} {(quantidadeTotal > 1 ? "itens" : "item")}): {RetornarSomaTotal()}";
        }

        public int RetornarQuantidadeTotal() =>
            _vendaProdutosBinding.Sum(x => x.Quantidade);

        public string RetornarSomaTotal()
        {
            Preco total = 0;

            foreach (var vendaProdutoModel in _vendaProdutosBinding)
                total += ((vendaProdutoModel.PrecoVenda - vendaProdutoModel.Desconto) *
                        vendaProdutoModel.Quantidade);
            return total.Formatado;
        }

        public UcCarrinhoVenda RetornarUserControl() => _ucCarrinhoVenda;

        public void AtribuirProdutoSelecionadoParaDesconto(VendaProdutoModel vendaProdutoSelecionado) =>
            _produtoSelecionadoParaDesconto = vendaProdutoSelecionado;

        public VendaProdutoModel RetornarVendaProdutoSelecionadoParaDesconto() => 
            _produtoSelecionadoParaDesconto;

        public BindingList<VendaProdutoModel> RetornarListasDeProdutosParaDesconto() => _vendaProdutosBinding;

        public void AtualizarCarrinho() =>
            _ucCarrinhoVenda.AtualizarCarrinho();
    }
}
