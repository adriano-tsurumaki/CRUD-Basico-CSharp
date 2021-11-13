using CRUD___Adriano.Features.Produto.Dao;
using CRUD___Adriano.Features.Vendas.View;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class PesquisarProdutoController
    {
        private readonly ProdutoDao _produtoDao;
        private readonly UcPesquisarProduto _ucPesquisarProduto;

        public PesquisarProdutoController(ProdutoDao produtoDao)
        {
            _produtoDao = produtoDao;
            _ucPesquisarProduto = new UcPesquisarProduto(this);
        }

        public UcPesquisarProduto RetornarUserControl() => _ucPesquisarProduto;
    }
}
