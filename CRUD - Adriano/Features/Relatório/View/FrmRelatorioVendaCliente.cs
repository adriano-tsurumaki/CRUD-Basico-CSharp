using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Relatório.Controller;
using CRUD___Adriano.Features.Relatório.Enum;
using CRUD___Adriano.Features.Relatório.Model;
using CRUD___Adriano.Features.Usuario.Controller;
using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.Vendas.Sql;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Relatório.View
{
    public partial class FrmRelatorioVendaCliente : Form
    {
        private readonly RelatorioVendaClienteController _controller;
        private ClienteModel _clienteFiltroSelecionado;
        private readonly BindingList<ClienteModel> _bindingClientes;

        public FrmRelatorioVendaCliente(RelatorioVendaClienteController controller)
        {
            InitializeComponent();
            _controller = controller;
            cbComparador.AtribuirPeloEnum<ComparadorEnum>();
            cbOrdernador.AtribuirPeloEnum<OrdernarClienteVendaEnum>();
            _bindingClientes = new BindingList<ClienteModel>();
            CustomizandoGrid();
        }

        private void CustomizandoGrid()
        {
            DataGridViewCell celulaGridView = new DataGridViewTextBoxCell();

            gridView.TextBoxColumnPadrao(celulaGridView, "Nome", "NomeCliente", true);
            gridView.TextBoxColumnPadrao(celulaGridView, "Quantidade", "QuantidadeVendas", true);
            gridView.TextBoxColumnPadrao(celulaGridView, "Total bruto", "TotalBruto.Formatado", true);
            gridView.TextBoxColumnPadrao(celulaGridView, "Desconto total", "DescontoTotal.Formatado", true);
            gridView.TextBoxColumnPadrao(celulaGridView, "Total Líquido", "TotalLiquido.Formatado", true);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = _controller.RetornarBindingRelatorioVendaCliente();
            _controller.AtualizarLista();
            AtualizarTotalizadores();

            DataGridViewCell celulaGridViewFiltroCliente = new DataGridViewTextBoxCell();

            gridViewClienteFiltro.TextBoxColumnPadrao(celulaGridViewFiltroCliente, "Id", "IdUsuario", true);
            gridViewClienteFiltro.TextBoxColumnPadrao(celulaGridViewFiltroCliente, "Nome", "Nome", true);
            gridViewClienteFiltro.AutoGenerateColumns = false;
            gridViewClienteFiltro.DataSource = _bindingClientes;
        }

        private void BtnAbrirFiltro_Click(object sender, System.EventArgs e) =>
            pnlRight.Visible = !pnlRight.Visible;

        private void BtnPesquisarCliente_Click(object sender, System.EventArgs e)
        {
            var clienteModel = ConfigNinject.ObterInstancia<BuscarUsuarioController<ClienteModel>>()
                .DefinirTituloDoForm("Listagem de Clientes").RetornarUsuarioSelecionado();

            if (_controller.PossuiClienteNaListaDoFiltro(clienteModel.IdUsuario) || clienteModel.IdUsuario == 0) return;

            if (!_controller.PossuiClientesSelecionadosNoFiltro() && clienteModel.IdUsuario == 0)
            {
                HabilitarFiltragemEmLista(true);
                return;
            }

            txtCliente.Text = clienteModel.Nome;
            _bindingClientes.Add(clienteModel);
            _controller.AdicionarIdClienteNoFiltro(clienteModel.IdUsuario);
            
            HabilitarFiltragemEmLista(false);
        }

        private void BtnDeselecionarCliente_Click(object sender, System.EventArgs e)
        {
            if (!_controller.PossuiClientesSelecionadosNoFiltro()) return;

            var clienteModelSelecionado = gridViewClienteFiltro.CurrentRow.DataBoundItem as ClienteModel;

            _bindingClientes.Remove(clienteModelSelecionado);
            _controller.RemoverIdClienteNoFiltro(clienteModelSelecionado.IdUsuario);
            
            if (!_controller.PossuiClientesSelecionadosNoFiltro())
            {
                txtCliente.Text = "Não selecionado";
                HabilitarFiltragemEmLista(true);
            }
        }

        private void HabilitarFiltragemEmLista(bool habilitar)
        {
            pnlLimitarCliente.Visible = habilitar;
            pnlOrdernarPor.Visible = habilitar;
            pnlListagemCliente.Visible = !habilitar;
        }

        private void BtnFiltrar_Click(object sender, System.EventArgs e)
        {
            if (!ValidarCampos()) return;

            AtribuirFiltroDeData();

            if (!_controller.PossuiClientesSelecionadosNoFiltro())
            {
                _controller.DefinirLimiteClienteNoFiltro(txtQuantidade.Texto.IntOuZero());

                AtribuirFiltroOrdenador();

                _controller.DefinirOrdernarCrescente(checkCrescente.Checked);
            }
            else
                _controller.DefinirLimiteClienteNoFiltro(0);

            AtribuirFiltroComparador();

            _controller.DefinirValorNoFiltro(txtValor.Texto.DoubleOuZero());

            _controller.AtualizarLista();
            AtualizarTotalizadores();
        }

        private bool ValidarCampos()
        {
            if (checkDataFiltro.Checked && dtDataInicio.Value.ZerarHorario() > dtDataFinal.Value.ZerarHorario())
            {
                MessageBox.Show("A data de início não pode ser maior que a data final");
                return false;
            }

            if (!txtQuantidade.NuloOuVazio() && !txtQuantidade.Numerico() && pnlLimitarCliente.Visible)
            {
                MessageBox.Show("O campo quantidade deve ser numérico!");
                return false;
            }

            if (cbComparador.EstaSelecionado() && !txtValor.Monetario())
            {
                MessageBox.Show("O campo de valor deve estar preenchido e ser numérico para filtrar!");
                return false;
            }

            return true;
        }

        private void AtribuirFiltroDeData()
        {
            if (checkDataFiltro.Checked)
            {
                _controller.DefinirDataInicioNoFiltro(dtDataInicio.Value);
                _controller.DefinirDataFinalNoFiltro(dtDataFinal.Value);
            }
            else
            {
                _controller.DefinirDataInicioNoFiltro(DateTime.MinValue);
                _controller.DefinirDataFinalNoFiltro(DateTime.MinValue);
            }
        }

        public void AtribuirFiltroComparador()
        {
            if (cbComparador.EstaSelecionado())
                _controller.DefinirTipoComparadorNoFiltro(cbComparador.PegarEnumPorDescricao<ComparadorEnum>());
            else
                _controller.DefinirTipoComparadorNoFiltro(0);
        }

        private void AtribuirFiltroOrdenador()
        {
            if (cbOrdernador.EstaSelecionado() && pnlOrdernarPor.Visible)
                _controller.DefinirTipoOrdernacaoNoFiltro(cbOrdernador.PegarEnumPorDescricao<OrdernarClienteVendaEnum>());
            else
                _controller.DefinirTipoOrdernacaoNoFiltro(0);
        }

        private void AtualizarTotalizadores()
        {
            txtQuantidadeTotal.Text = _controller.RetornarQuantidadeTotalDaLista();
            txtTotalBruto.Text = _controller.RetornarTotalBrutoDaLista();
            txtDescontoTotal.Text = _controller.RetornarDescontoTotalDaLista();
            txtTotalLiquido.Text = _controller.RetornarTotalLiquidoDaLista();
        }

        private void CheckDataFiltro_CheckedChanged(object sender, System.EventArgs e) =>
            pnlFiltroData.Visible = checkDataFiltro.Checked;

        private void GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!(gridView.Rows[e.RowIndex].DataBoundItem is RelatorioVendaClienteModel) || !gridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")) return;

            e.Value = gridView.BindProperty(gridView.Rows[e.RowIndex].DataBoundItem, gridView.Columns[e.ColumnIndex].DataPropertyName);
        }

        private void GridViewClienteFiltro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridView.CurrentRow == null) return;

            _clienteFiltroSelecionado = gridViewClienteFiltro.CurrentRow.DataBoundItem as ClienteModel;

            txtCliente.Text = _clienteFiltroSelecionado.Nome;
        }
    }
}
