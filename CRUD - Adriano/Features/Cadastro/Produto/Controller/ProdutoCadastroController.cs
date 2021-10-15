using CRUD___Adriano.Features.Cadastro.Produto.View;

namespace CRUD___Adriano.Features.Cadastro.Produto.Controller
{
    public class ProdutoCadastroController
    {
        private FrmCadastroProduto _frmCadastroProduto;

        public ProdutoCadastroController()
        {
            _frmCadastroProduto = new FrmCadastroProduto(this);
        }
    }
}
