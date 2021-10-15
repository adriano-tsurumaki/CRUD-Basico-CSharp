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

        private void BtnCadastrar_Click(object sender, System.EventArgs e) =>
            _produtoCadastroController.EfetuarCadastroDoProduto();

        private void BtnCancelar_Click(object sender, System.EventArgs e) =>
            Close();

        private void FrmCadastroProduto_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.F5:
                    _produtoCadastroController.EfetuarCadastroDoProduto();
                    break;
            }
        }
    }
}
