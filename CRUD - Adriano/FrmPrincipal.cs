using CRUD___Adriano.Features;
using CRUD___Adriano.Features.Cadastro.Produto.Controller;
using CRUD___Adriano.Features.Cliente.Controller;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            FluentMap.InicializarMap();
        }

        private void BtnClienteCadastro_Click(object sender, EventArgs e) =>
            new ClienteCadastroController().AbrirFormulario();

        private void BtnClientesListagem_Click(object sender, EventArgs e) =>
            new ClienteListagemController().AbrirFormulario();
    }
}
