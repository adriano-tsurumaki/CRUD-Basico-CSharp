using CRUD___Adriano.Features.Cadastro.Produto.Controller;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cadastro.Produto.View
{
    public partial class FrmCadastroCliente : Form
    {
        private ClienteCadastroController _produtoCadastroController;

        public FrmCadastroCliente(ClienteCadastroController produtoCadastroController)
        {
            InitializeComponent();
            _produtoCadastroController = produtoCadastroController;
            txtNome.Focus();
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

        private void textBoxFlat1__TextChanged(object sender, System.EventArgs e)
        {

        }

        private void lbQuantidade_Click(object sender, System.EventArgs e)
        {

        }
    }
}
