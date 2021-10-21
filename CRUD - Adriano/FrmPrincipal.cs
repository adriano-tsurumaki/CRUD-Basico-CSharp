using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cadastro.Usuario.View;
using CRUD___Adriano.Features.Cliente.Controller;
using CRUD___Adriano.Features.Cliente.View;
using CRUD___Adriano.Features.Configuration;
using CRUD___Adriano.Features.Controller.PageManager;
using CRUD___Adriano.Features.Factory;
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
            var pageManager = new GerenciadorDePaginas<ClienteModel>(
                pnlChild,
                new ClienteController(new ControllerConexao()),
                new ClienteModel());

            pageManager.Add(new FrmCadastroUsuario<ClienteModel>());
            pageManager.Add(new FrmCadastroCliente());
            pageManager.Show();
        }

        private void BtnClientesListagem_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Listagem de clientes";
            //DocaForm(new ClienteListagemController().RetornarFormulario());
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

        private void BtnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            
        }
    }
}
