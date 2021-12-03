using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Produto.Model;
using CRUD___Adriano.Features.Relatório.Controller;
using CRUD___Adriano.Features.Usuario.Controller;
using CRUD___Adriano.Features.Utils;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Relatório.View
{
    public partial class FrmRelatorioVendaProduto : Form
    {
        private readonly RelatorioVendaProdutoController _controller;

        public FrmRelatorioVendaProduto(RelatorioVendaProdutoController controller)
        {
            InitializeComponent();
            _controller = controller;
            gridView.DataSource = _controller.ListarTodosProdutosPeloFiltro();
        }

        private void BtnAbrirFiltro_Click(object sender, System.EventArgs e) =>
            pnlRight.Visible = !pnlRight.Visible;

        private void CheckDataFiltro_CheckedChanged(object sender, System.EventArgs e) =>
            pnlFiltroData.Visible = checkDataFiltro.Checked;

        private void BtnPesquisarProduto_Click(object sender, System.EventArgs e)
        {
            var produtoModel = ConfigNinject.ObterInstancia<BuscarUsuarioController<ProdutoModel>>()
                .DefinirTituloDoForm("Listagem de Produtos").RetornarUsuarioSelecionado();

            if (produtoModel.Id == 0) return;

            txtProduto.Text = produtoModel.Nome;
            _controller.DefinirIdProdutoNoFiltro(produtoModel.Id);
        }

        private void BtnDeselecionarProduto_Click(object sender, System.EventArgs e)
        {
            txtProduto.Text = "Não selecionado";
            _controller.DefinirIdProdutoNoFiltro(0);
        }

        private void BtnPesquisarCliente_Click(object sender, System.EventArgs e)
        {
            var clienteModel = ConfigNinject.ObterInstancia<BuscarUsuarioController<ClienteModel>>()
                .DefinirTituloDoForm("Listagem de Clientes").RetornarUsuarioSelecionado();

            if (clienteModel.IdUsuario == 0) return;

            txtCliente.Text = clienteModel.Nome;
            _controller.DefinirIdClienteNoFiltro(clienteModel.IdUsuario);
        }

        private void BtnDeselecionarCliente_Click(object sender, System.EventArgs e)
        {
            txtCliente.Text = "Não selecionado";
            _controller.DefinirIdClienteNoFiltro(0);
        }

        private void BtnFiltrar_Click(object sender, System.EventArgs e)
        {
            if (checkDataFiltro.Checked)
            {
                if (dtDataInicio.Value.ZerarHorario() > dtDataFinal.Value.ZerarHorario())
                {
                    MessageBox.Show("A data de início não pode ser maior que a data final");
                    return;
                }

                _controller.DefinirDataInicioNoFiltro(dtDataInicio.Value);
                _controller.DefinirDataFinalNoFiltro(dtDataFinal.Value);
            }
            else
            {
                _controller.DefinirDataInicioNoFiltro(DateTime.MinValue);
                _controller.DefinirDataFinalNoFiltro(DateTime.MinValue);
            }

            gridView.DataSource = _controller.ListarTodosProdutosPeloFiltro();
        }
    }
}
