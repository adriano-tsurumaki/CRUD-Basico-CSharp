﻿using CRUD___Adriano.Features.Atalhos.Controller;
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
using CRUD___Adriano.Features.Vendas.View;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano
{
    public partial class FrmPrincipal : Form
    {
        private Form _formFilhaAtiva;

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

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            LimparPanel();
            ConfigNinject.ObterInstancia<VendaPrincipalController>();
        }

        private void BtnListagemVenda_Click(object sender, EventArgs e)
        {
            LimparPanel();
            lblTitulo.Text = "Listagem de vendas";
            DocaForm(ConfigNinject.ObterInstancia<VendaListagemController>().RetornarFormulario());
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
                MessageBox.Show(excecao.Message, "Ocorre um erro ao tentar deslogar");
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
                MessageBox.Show(excecao.Message, "Ocorre um erro ao tentar buscar o nome do usuário logado");
            }
        }
    }
}
