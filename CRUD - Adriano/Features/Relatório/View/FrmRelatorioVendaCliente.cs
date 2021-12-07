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

        public FrmRelatorioVendaCliente(RelatorioVendaClienteController controller)
        {
            InitializeComponent();
            _controller = controller;
            cbComparador.AtribuirPeloEnum<ComparadorEnum>();
            cbOrdernador.AtribuirPeloEnum<OrdernarClienteVendaEnum>();
            CustomizandoGrid();
        }

        private void CustomizandoGrid()
        {
            DataGridViewCell celula = new DataGridViewTextBoxCell();

            gridView.TextBoxColumnPadrao(celula, "Nome", "NomeCliente", true);
            gridView.TextBoxColumnPadrao(celula, "Quantidade", "QuantidadeVendas", true);
            gridView.TextBoxColumnPadrao(celula, "Total bruto", "TotalBruto.Formatado", true);
            gridView.TextBoxColumnPadrao(celula, "Desconto total", "DescontoTotal.Formatado", true);
            gridView.TextBoxColumnPadrao(celula, "Total Líquido", "TotalLiquido.Formatado", true);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = new BindingList<RelatorioVendaClienteModel>(_controller.ListarTodosProdutosPeloFiltro());
        }

        private void BtnAbrirFiltro_Click(object sender, System.EventArgs e) =>
            pnlRight.Visible = !pnlRight.Visible;

        private void BtnPesquisarCliente_Click(object sender, System.EventArgs e)
        {
            var clienteModel = ConfigNinject.ObterInstancia<BuscarUsuarioController<ClienteModel>>()
                .DefinirTituloDoForm("Listagem de Clientes").RetornarUsuarioSelecionado();

            if (clienteModel.IdUsuario == 0)
            {
                HabilitarOuDesabilitarFiltragemEmLista(true);
                return;
            }

            txtCliente.Text = clienteModel.Nome;
            _controller.DefinirIdClienteNoFiltro(clienteModel.IdUsuario);
            HabilitarOuDesabilitarFiltragemEmLista(false);
        }

        private void BtnDeselecionarCliente_Click(object sender, System.EventArgs e)
        {
            txtCliente.Text = "Não selecionado";
            _controller.DefinirIdClienteNoFiltro(0);
            HabilitarOuDesabilitarFiltragemEmLista(true);
        }

        private void HabilitarOuDesabilitarFiltragemEmLista(bool habilitar)
        {
            pnlLimitarCliente.Visible = habilitar;
            pnlOrdernarPor.Visible = habilitar;
        }

        private void BtnFiltrar_Click(object sender, System.EventArgs e)
        {
            if (!ValidarCampos()) return;

            AtribuirFiltroDeData();

            if (txtCliente.Text == "Não selecionado")
            {
                _controller.DefinirLimiteClienteNoFiltro(txtQuantidade.Texto.IntOuZero());

                AtribuirFiltroOrdenador();

                _controller.DefinirOrdernarCrescente(checkCrescente.Checked);
            }
            else
                _controller.DefinirLimiteClienteNoFiltro(0);

            AtribuirFiltroComparador();
            _controller.DefinirValorNoFiltro(txtValor.Texto.DoubleOuZero());
            
            gridView.DataSource = new BindingList<RelatorioVendaClienteModel>(_controller.ListarTodosProdutosPeloFiltro());
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

        private void CheckDataFiltro_CheckedChanged(object sender, System.EventArgs e) =>
            pnlFiltroData.Visible = checkDataFiltro.Checked;

        private void GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!(gridView.Rows[e.RowIndex].DataBoundItem is RelatorioVendaClienteModel model) || !gridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")) return;

            e.Value = gridView.BindProperty(gridView.Rows[e.RowIndex].DataBoundItem, gridView.Columns[e.ColumnIndex].DataPropertyName);
        }
    }
}
