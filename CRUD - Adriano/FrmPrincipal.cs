using CRUD___Adriano.Features.Cadastro.Produto.Controller;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnTelaCadastro_Click(object sender, EventArgs e)
        {
            new ProdutoCadastroController().AbrirFormulario();
        }
    }
}
