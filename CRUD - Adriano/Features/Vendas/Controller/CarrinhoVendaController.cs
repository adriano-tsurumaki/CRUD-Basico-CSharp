using CRUD___Adriano.Features.ValueObject.Precos;
using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class CarrinhoVendaController
    {
        private readonly UcCarrinhoVenda _ucCarrinhoVenda;
        private BindingList<VendaProdutoModel> _vendaProdutosBinding;
        private VendaProdutoModel _produtoSelecionadoParaDesconto;

        public CarrinhoVendaController()
        {
            _vendaProdutosBinding = new BindingList<VendaProdutoModel>();
            _ucCarrinhoVenda = new UcCarrinhoVenda(this);
        }

        public void AdicionarModel(IList<VendaProdutoModel> listaDeProdutos)
        {
            _vendaProdutosBinding = new BindingList<VendaProdutoModel>(listaDeProdutos);
            _ucCarrinhoVenda.BindModel(_vendaProdutosBinding);
        }

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
                total += vendaProdutoModel.PrecoLiquido;

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
