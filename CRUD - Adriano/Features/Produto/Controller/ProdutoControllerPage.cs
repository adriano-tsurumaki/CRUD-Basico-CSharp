using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Interface;
using CRUD___Adriano.Features.Produto.Model;
using CRUD___Adriano.Features.Produto.View;

namespace CRUD___Adriano.Features.Produto.Controller
{
    public class ProdutoControllerPage : IControllerPage<ProdutoModel>
    {
        private readonly IViewPage<ProdutoModel> _frmCadastroProduto;

        public ProdutoControllerPage()
        {
            _frmCadastroProduto = new FrmCadastroProduto(this);
        }

        public IViewPage<ProdutoModel> RetornarFormulario() => _frmCadastroProduto;

        public void AdicionarModel(ref ProdutoModel produtoModel) =>
            _frmCadastroProduto.BindModel(ref produtoModel);

        public bool ValidarForm() => _frmCadastroProduto.ValidarComponentes();
    }
}
