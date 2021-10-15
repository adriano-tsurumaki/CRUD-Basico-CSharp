using CRUD___Adriano.Features.Cadastro.Produto.Controller;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cadastro.Produto.View
{
    public partial class FrmCadastroProduto : Form
    {
        private ProdutoCadastroController _produtoCadastroController;

        public FrmCadastroProduto(ProdutoCadastroController produtoCadastroController)
        {
            InitializeComponent();
            _produtoCadastroController = produtoCadastroController;
        }
    }
}
