using CRUD___Adriano.Features;
using CRUD___Adriano.Features.Cadastro.Produto.Controller;
using CRUD___Adriano.Features.Cliente.Controller;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano
{
    public partial class FrmPrincipal : Form
    {
        private Form formFilhaAtiva;

        public FrmPrincipal()
        {
            InitializeComponent();

            FluentMap.InicializarMap();
            EsconderSubmenu();
        }

        private void EsconderSubmenu()
        {
            pnlCadastroSubmenu.Visible = false;
            pnlListagemSubmenu.Visible = false;
        }

        private void BtnClienteCadastro_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Cadastro de cliente";
            DocaForm(new ClienteCadastroController().RetornarFormulario());
        }

        private void BtnClientesListagem_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Listagem de clientes";
            DocaForm(new ClienteListagemController().RetornarFormulario());
        }

        public void DocaForm(Form formFilha)
        {
            if (formFilhaAtiva != null)
                formFilhaAtiva.Close();
            formFilhaAtiva = formFilha;

            formFilha.TopLevel = false;
            formFilha.FormBorderStyle = FormBorderStyle.None;
            formFilha.Dock = DockStyle.Fill;
            pnlChild.Controls.Add(formFilha);
            pnlChild.Tag = formFilha;
            formFilha.BringToFront();
            formFilha.Show();
            formFilha.Focus();
        }

        private void BtnMenuCadastro_Click(object sender, EventArgs e)
        {
            TrocarVisibilidade(pnlCadastroSubmenu);
            EsconderSubmenusRestantes(pnlCadastroSubmenu);
        }

        private void BtnMenuListagem_Click(object sender, EventArgs e)
        {
            TrocarVisibilidade(pnlListagemSubmenu);
            EsconderSubmenusRestantes(pnlListagemSubmenu);
        }

        private void TrocarVisibilidade(Panel subMenu) =>
            subMenu.Visible = !subMenu.Visible;

        private void EsconderSubmenusRestantes(Panel submenu)
        {
            var visibilidade = submenu.Visible;
            pnlCadastroSubmenu.Visible = false;
            pnlListagemSubmenu.Visible = false;
            submenu.Visible = visibilidade;
        }

        private void PnlChild_ControlRemoved(object sender, ControlEventArgs e)
        {
            lblTitulo.Text = "Dashboard";
        }
    }
}
