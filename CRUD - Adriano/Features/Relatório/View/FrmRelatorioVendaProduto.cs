using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Produto.Model;
using CRUD___Adriano.Features.Relatório.Controller;
using CRUD___Adriano.Features.Relatório.Model;
using CRUD___Adriano.Features.Usuario.Controller;
using CRUD___Adriano.Features.Utils;
using System;
using System.ComponentModel;
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
            CustomizandoGrid();
        }

        private void CustomizandoGrid()
        {
            DataGridViewCell celula = new DataGridViewTextBoxCell();

            gridView.TextBoxColumnPadrao(celula, "Id", "IdProduto", true);
            gridView.TextBoxColumnPadrao(celula, "Nome", "NomeProduto", true);
            gridView.TextBoxColumnPadrao(celula, "Quantidade", "Quantidade", true);
            gridView.TextBoxColumnPadrao(celula, "Preço bruto total", "PrecoBrutoTotal.Formatado", true);
            gridView.TextBoxColumnPadrao(celula, "Total de desconto", "DescontoTotal.Formatado", true);
            gridView.TextBoxColumnPadrao(celula, "Lucro total (%)", "LucroTotalPorcentagem", true);
            gridView.TextBoxColumnPadrao(celula, "Lucro total", "LucroTotal.Formatado", true);
            gridView.TextBoxColumnPadrao(celula, "Preço líquido total", "PrecoLiquidoTotal.Formatado", true);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = new BindingList<RelatorioVendaProdutoModel>(_controller.ListarTodosProdutosPeloFiltro());
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

        private void GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!(gridView.Rows[e.RowIndex].DataBoundItem is RelatorioVendaProdutoModel model)) return;

            if (gridView.Columns[e.ColumnIndex].DataPropertyName == "LucroTotalPorcentagem")
            {
                e.Value = $"{Math.Round(model.LucroTotalPorcentagem, 2)} %";
                return;
            }

            if (!gridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")) return;

            e.Value = gridView.BindProperty(gridView.Rows[e.RowIndex].DataBoundItem, gridView.Columns[e.ColumnIndex].DataPropertyName);
        }
    }
}
