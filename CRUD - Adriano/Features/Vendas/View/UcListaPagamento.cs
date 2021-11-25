using CRUD___Adriano.Features.Vendas.Controller;
using CRUD___Adriano.Features.Vendas.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class UcListaPagamento : UserControl
    {
        public delegate void AtualizarFormaPagamentoHandler();

        public event AtualizarFormaPagamentoHandler EventAtualizarFormaPagamento;

        private readonly ListaPagamentoController _controller;
        private BindingList<FormaPagamentoModel> _listaFormaPagamento;

        public UcListaPagamento(ListaPagamentoController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        public void BindModel(BindingList<FormaPagamentoModel> listaFormaPagamento)
        {
            gridView.Columns.Clear();
            DataGridViewCell celula = new DataGridViewTextBoxCell();

            DataGridViewTextBoxColumn posicaoColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "Posição",
                DataPropertyName = "PosicaoPagamento",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    BackColor = Color.FromArgb(23, 31, 32),
                    SelectionForeColor = Color.Black,
                    SelectionBackColor = Color.LightSeaGreen,
                    Padding = new Padding(2)
                },
                ReadOnly = false,
            };

            DataGridViewTextBoxColumn valorAPagarColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "Valor pago",
                DataPropertyName = "ValorAPagar.Formatado",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.Crimson,
                    BackColor = Color.FromArgb(23, 31, 32),
                    SelectionForeColor = Color.Black,
                    SelectionBackColor = Color.LightSeaGreen,
                    Padding = new Padding(2)
                },
                ReadOnly = true,
            };

            DataGridViewTextBoxColumn tipoPagamentoColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "Tipo de pagamento",
                DataPropertyName = "TipoPagamento",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point),
                    ForeColor = Color.DodgerBlue,
                    BackColor = Color.FromArgb(23, 31, 32),
                    SelectionBackColor = Color.LightSeaGreen,
                    Padding = new Padding(2)
                },
                ReadOnly = true,
            };

            DataGridViewTextBoxColumn quantidadeParcelasColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "Quantidade de parcelas",
                DataPropertyName = "QuantidadeParcelas",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point),
                    ForeColor = Color.DodgerBlue,
                    BackColor = Color.FromArgb(23, 31, 32),
                    SelectionBackColor = Color.LightSeaGreen,
                    Padding = new Padding(2)
                },
                ReadOnly = true,
            };

            DataGridViewTextBoxColumn posicaoParcelaColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "Posição na parcela",
                DataPropertyName = "PosicaoParcela",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point),
                    ForeColor = Color.DodgerBlue,
                    BackColor = Color.FromArgb(23, 31, 32),
                    SelectionBackColor = Color.LightSeaGreen,
                    Padding = new Padding(2)
                },
                ReadOnly = true,
            };

            gridView.Columns.Add(posicaoColuna);
            gridView.Columns.Add(valorAPagarColuna);
            gridView.Columns.Add(tipoPagamentoColuna);
            gridView.Columns.Add(quantidadeParcelasColuna);
            gridView.Columns.Add(posicaoParcelaColuna);

            gridView.AutoGenerateColumns = false;
            _listaFormaPagamento = listaFormaPagamento;
            gridView.DataSource = _listaFormaPagamento;
        }

        private void GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!(gridView.Rows[e.RowIndex].DataBoundItem is FormaPagamentoModel) || !gridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")) return;

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

        private void GridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && gridView.HitTest(e.X, e.Y).RowIndex >= 0)
            {
                var mouseXY = gridView.HitTest(e.X, e.Y);

                gridView.ClearSelection();
                gridView.Rows[mouseXY.RowIndex].Selected = true;

                var menuPopup = new ContextMenuStrip();

                menuPopup.ItemClicked += MenuPopup_ItemClicked;

                var item = new ToolStripMenuItem();

                menuPopup.Items.Add("Deletar").Name = "Deletar";
                menuPopup.Show(gridView, new Point(e.X, e.Y));
            }
        }

        private void MenuPopup_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var formaPagamentoSelecionado = gridView.CurrentRow.DataBoundItem as FormaPagamentoModel;
            switch (e.ClickedItem.Name)
            {
                case "Deletar":
                    _listaFormaPagamento.Remove(formaPagamentoSelecionado);
                    break;
                default:
                    return;
            }

            EventAtualizarFormaPagamento?.Invoke();
        }

        private void gridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
