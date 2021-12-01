using CRUD___Adriano.Features.Atalhos.Controller;
using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.Controller;
using CRUD___Adriano.Features.Colaborador.Controller;
using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.Configuration.Login.Dao;
using CRUD___Adriano.Features.Controller.PageManager;
using CRUD___Adriano.Features.Dashboards.Controller;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Fornecedor.Controller;
using CRUD___Adriano.Features.Fornecedor.Model;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Produto.Controller;
using CRUD___Adriano.Features.Produto.Model;
using CRUD___Adriano.Features.Usuario.Controller;
using CRUD___Adriano.Features.Vendas.Controller;
using CRUD___Adriano.Features.Vendas.Dao;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CRUD___Adriano
{
    public partial class FrmPrincipal : Form
    {
        private Form _formFilhaAtiva;

        public FrmPrincipal()
        {
            InitializeComponent();
            DocaForm(ConfigNinject.ObterInstancia<DashboardController>().RetornarFormulario());
            EsconderSubmenu();
            CarregarTitleBar();
        }

        private void EsconderSubmenu()
        {
            pnlCadastroSubmenu.Visible = false;
            pnlListagemSubmenu.Visible = false;
            pnlProdutoSubmenu.Visible = false;
            pnlVendaSubmenu.Visible = false;
        }

        private void BtnClienteCadastro_Click(object sender, EventArgs e)
        {
            LimparPanel();
            lblTitulo.Text = "Cadastro de cliente";
            var pageManager = new GerenciadorDePaginas<ClienteModel>(
                pnlChild,
                ConfigNinject.ObterInstancia<ClienteController>(),
                new ClienteModel());

            pageManager.Adicionar(ConfigNinject.ObterInstancia<UsuarioControllerPage<ClienteModel>>());
            pageManager.Adicionar(ConfigNinject.ObterInstancia<EmailTelefoneControllerPage<ClienteModel>>());
            pageManager.Adicionar(ConfigNinject.ObterInstancia<ClienteControllerPage>());
            pageManager.DefinirTipoCrud(ControllerEnum.Salvar);
            pageManager.DefinirMensagemConfirmacao("Deseja cadastrar o cliente?");
            pageManager.Mostrar();
        }

        private void BtnClientesListagem_Click(object sender, EventArgs e)
        {
            LimparPanel();
            lblTitulo.Text = "Listagem de clientes";
            DocaForm(
                new ClienteListagemController(
                    ConfigNinject.ObterInstancia<ClienteController>(),
                    pnlChild)
                .RetornarFormulario());
        }

        private void BtnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            LimparPanel();
            lblTitulo.Text = "Cadastro de colaborador";
            var pageManager = new GerenciadorDePaginas<ColaboradorModel>(
                pnlChild,
                ConfigNinject.ObterInstancia<ColaboradorController>(),
                new ColaboradorModel());

            pageManager.Adicionar(ConfigNinject.ObterInstancia<UsuarioControllerPage<ColaboradorModel>>());
            pageManager.Adicionar(ConfigNinject.ObterInstancia<EmailTelefoneControllerPage<ColaboradorModel>>());
            pageManager.Adicionar(ConfigNinject.ObterInstancia<ColaboradorControllerPage>());
            pageManager.DefinirTipoCrud(ControllerEnum.Salvar);
            pageManager.DefinirMensagemConfirmacao("Deseja cadastrar o funcionário?");
            pageManager.Mostrar();
        }

        private void BtnListagemFuncionario_Click(object sender, EventArgs e)
        {
            LimparPanel();
            lblTitulo.Text = "Listagem de Funcionários";
            DocaForm(
                new ColaboradorListagemController(
                    ConfigNinject.ObterInstancia<ColaboradorController>(),
                    pnlChild)
                .RetornarFormulario());
        }

        private void BtnCadastroFornecedor_Click(object sender, EventArgs e)
        {
            LimparPanel();
            lblTitulo.Text = "Cadastro de fornecedor";
            var pageManager = new GerenciadorDePaginas<FornecedorModel>(
                pnlChild,
                ConfigNinject.ObterInstancia<FornecedorController>(),
                new FornecedorModel());

            pageManager.Adicionar(ConfigNinject.ObterInstancia<UsuarioControllerPage<FornecedorModel>>());
            pageManager.Adicionar(ConfigNinject.ObterInstancia<EmailTelefoneControllerPage<FornecedorModel>>());
            pageManager.Adicionar(ConfigNinject.ObterInstancia<FornecedorControllerPage>());
            pageManager.DefinirTipoCrud(ControllerEnum.Salvar);
            pageManager.DefinirMensagemConfirmacao("Deseja cadastrar o fornecedor?");
            pageManager.Mostrar();
        }

        private void BtnCadastroProduto_Click(object sender, EventArgs e)
        {
            LimparPanel();
            lblTitulo.Text = "Cadastro de produto";
            var pageManager = new GerenciadorDePaginas<ProdutoModel>(
                pnlChild,
                ConfigNinject.ObterInstancia<ProdutoController>(),
                new ProdutoModel());

            pageManager.Adicionar(ConfigNinject.ObterInstancia<ProdutoControllerPage>());
            pageManager.DefinirTipoCrud(ControllerEnum.Salvar);
            pageManager.DefinirMensagemConfirmacao("Deseja cadastrar o produto?");
            pageManager.Mostrar();
        }

        private void BtnAtalho_Click(object sender, EventArgs e)
        {
            LimparPanel();
            lblTitulo.Text = "Atalhos";
            DocaForm(ConfigNinject.ObterInstancia<AtalhoController>().RetornarFormulario());
        }

        private void LblNomeEmpresa_Click(object sender, EventArgs e)
        {
            LimparPanel();
            lblTitulo.Text = "Dashboard";
            DocaForm(ConfigNinject.ObterInstancia<DashboardController>().RetornarFormulario());
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

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            TrocarVisibilidade(pnlProdutoSubmenu);
            EsconderSubmenusRestantes(pnlProdutoSubmenu);
        }

        private void BtnListagemProduto_Click_1(object sender, EventArgs e)
        {
            LimparPanel();
            lblTitulo.Text = "Listagem de produto";
            DocaForm(
                new ProdutoListagemController(
                    ConfigNinject.ObterInstancia<ProdutoController>(),
                    pnlChild)
                .RetornarFormulario());
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            TrocarVisibilidade(pnlVendaSubmenu);
            EsconderSubmenusRestantes(pnlVendaSubmenu);
        }

        private void BtnIniciarVenda_Click(object sender, EventArgs e)
        {
            LimparPanel();
            ConfigNinject.ObterInstancia<VendaPrincipalController>().Start();
        }

        private void BtnListagemVenda_Click(object sender, EventArgs e)
        {
            LimparPanel();
            lblTitulo.Text = "Listagem de vendas";
            DocaForm(new VendaListagemController(ConfigNinject.ObterInstancia<VendaDao>(), pnlChild).RetornarFormulario());
        }

        private void TrocarVisibilidade(Panel subMenu) =>
            subMenu.Visible = !subMenu.Visible;

        private void EsconderSubmenusRestantes(Panel submenu)
        {
            var visibilidade = submenu.Visible;
            pnlCadastroSubmenu.Visible = false;
            pnlListagemSubmenu.Visible = false;
            pnlProdutoSubmenu.Visible = false;
            pnlVendaSubmenu.Visible = false;
            submenu.Visible = visibilidade;
        }

        private void PnlChild_ControlRemoved(object sender, ControlEventArgs e)
        {
            lblTitulo.Text = "";
        }

        private void LimparPanel() => pnlChild.Controls.Clear();

        private void DocaForm(Form formFilha)
        {
            if (_formFilhaAtiva != null)
                _formFilhaAtiva.Close();

            _formFilhaAtiva = formFilha;

            formFilha.TopLevel = false;
            formFilha.FormBorderStyle = FormBorderStyle.None;
            formFilha.Dock = DockStyle.Fill;
            pnlChild.Controls.Add(formFilha);
            pnlChild.Tag = formFilha;

            formFilha.BringToFront();
            formFilha.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigNinject.ObterInstancia<LoginDao>().Deslogar();
                Close();
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Ocorreu um erro ao tentar deslogar");
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsuarioLogado.Text = ConfigNinject.ObterInstancia<LoginDao>().RetornarUsuarioLogadoSomenteNome();
            }
            catch(Exception excecao)
            {
                lblUsuarioLogado.Text = string.Empty;
                MessageBox.Show(excecao.Message, "Ocorreu um erro ao tentar buscar o nome do usuário logado");
            }
        }

        private void CarregarTitleBar()
        {
            pnlTitleBar.MouseDown += PnlTitleBar_MouseDown;
            pnlTitleBar.MouseUp += PnlTitleBar_MouseUp;
            pnlTitleBar.MouseMove += PnlTitleBar_MouseMove;
        }

        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        private void PnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = e.Location;
        }

        private void PnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void PnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drag) return;

            Point p1 = new Point(e.X, e.Y);
            Point p2 = this.PointToScreen(p1);
            Point p3 = new Point(p2.X - this.startPoint.X,
                                 p2.Y - this.startPoint.Y);

            Location = p3;
        }

        private void BtnFechar_Click(object sender, EventArgs e) =>
            Close();

        private void BtnMinimizar_Click(object sender, EventArgs e) =>
            WindowState = FormWindowState.Minimized;
    }
}
