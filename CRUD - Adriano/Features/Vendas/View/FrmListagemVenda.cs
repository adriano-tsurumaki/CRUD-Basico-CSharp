using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.Vendas.Controller;
using CRUD___Adriano.Features.Vendas.Model;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class FrmListagemVenda : Form
    {
        private readonly VendaListagemController _controller;

        public FrmListagemVenda(VendaListagemController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        public void BindModel(BindingList<VendaModel> vendaModelBindings)
        {
            gridView.Columns.Clear();
            DataGridViewCell celula = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn idColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnId",
                HeaderText = "Id",
                DataPropertyName = "Id",
                ReadOnly = true,
            };

            DataGridViewTextBoxColumn nomeColaboradorColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnNomeColaborador",
                HeaderText = "Colaborador",
                DataPropertyName = "Colaborador.Nome",
                ReadOnly = true,
            };
            
            DataGridViewTextBoxColumn nomeClienteColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnNomeCliente",
                HeaderText = "Cliente",
                DataPropertyName = "Cliente.Nome",
                ReadOnly = true,
            };

            DataGridViewTextBoxColumn descontoTotalColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnDescontoTotal",
                HeaderText = "Desconto",
                DataPropertyName = "DescontoTotal.Valor",
                ReadOnly = true,
            };
            
            DataGridViewTextBoxColumn valorTotalColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnValorTotal",
                HeaderText = "Valor total",
                DataPropertyName = "ValorLiquidoTotal.Valor",
                ReadOnly = true,
            };

            DataGridViewButtonColumn botaoAlterarColuna = new DataGridViewButtonColumn()
            {
                CellTemplate = new DataGridViewButtonCell(),
                HeaderText = "Alterar",
                Name = "Alterar"
            };

            DataGridViewButtonColumn botaoExcluirColuna = new DataGridViewButtonColumn()
            {
                CellTemplate = new DataGridViewButtonCell(),
                HeaderText = "Excluir",
                Name = "Excluir"
            };

            gridView.Columns.Add(idColuna);
            gridView.Columns.Add(nomeColaboradorColuna);
            gridView.Columns.Add(nomeClienteColuna);
            gridView.Columns.Add(descontoTotalColuna);
            gridView.Columns.Add(valorTotalColuna);
            gridView.Columns.Add(botaoAlterarColuna);
            gridView.Columns.Add(botaoExcluirColuna);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = vendaModelBindings;
        }

        private void GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!(gridView.Rows[e.RowIndex].DataBoundItem is VendaModel model) || !gridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")) return;

            if (gridView.Columns[e.ColumnIndex].DataPropertyName == "Desconto.Formatado")
                e.Value = "-" + model.DescontoTotal.Formatado;
            else
                e.Value = BindProperty(gridView.Rows[e.RowIndex].DataBoundItem, gridView.Columns[e.ColumnIndex].DataPropertyName);
        }

        private object BindProperty(object propriedade, string nomeDaPropriedade)
        {
            string valorDeRetorno = "";

            if (nomeDaPropriedade.Contains("."))
            {
                var leftPropertyName = nomeDaPropriedade.Substring(0, nomeDaPropriedade.IndexOf("."));
                var arrayDePropriedades = propriedade.GetType().GetProperties();
                foreach (var informacaoDaPropriedade in arrayDePropriedades)
                {
                    if (informacaoDaPropriedade.Name == leftPropertyName)
                    {
                        valorDeRetorno = (string)BindProperty(
                          informacaoDaPropriedade.GetValue(propriedade, null),
                          nomeDaPropriedade[(nomeDaPropriedade.IndexOf(".") + 1)..]);
                        break;
                    }
                }
            }
            else
            {
                Type tipoDePropriedade;
                PropertyInfo informacaoDaPropriedade;
                tipoDePropriedade = propriedade.GetType();
                informacaoDaPropriedade = tipoDePropriedade.GetProperty(nomeDaPropriedade);
                valorDeRetorno = informacaoDaPropriedade.GetValue(propriedade, null).ToString();
            }
            return valorDeRetorno;
        }

        private void BtnPesquisar_Click(object sender, System.EventArgs e) =>
            PesquisarDeAcordoComOTexto();

        private void TxtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            PesquisarDeAcordoComOTexto();
        }

        private void PesquisarDeAcordoComOTexto()
        {
            if (txtPesquisar.NuloOuVazio())
                return;
            else if (txtPesquisar.Texto == "%")
                _controller.ListarTodos();
        }
    }
}
