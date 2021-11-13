using CRUD___Adriano.Features.Vendas.Dao;
using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class CarrinhoVendaController
    {
        private readonly VendaDao _vendaDao;
        private readonly UcCarrinhoVenda _ucCarrinhoVenda;
        private BindingList<VendaProdutoModel> _vendaProdutosBinding;

        public CarrinhoVendaController(VendaDao vendaDao)
        {
            _vendaDao = vendaDao;
            _vendaProdutosBinding = new BindingList<VendaProdutoModel>();
            _ucCarrinhoVenda = new UcCarrinhoVenda(this);
            AdicionarModel();
        }

        public void AdicionarModel() => _ucCarrinhoVenda.BindModel(_vendaProdutosBinding);

        public void AdicionarProdutoNoCarrinho(VendaProdutoModel vendaProdutoModel) =>
            _vendaProdutosBinding.Add(vendaProdutoModel);

        public UserControl RetornarUserControl() => _ucCarrinhoVenda;
    }
}
