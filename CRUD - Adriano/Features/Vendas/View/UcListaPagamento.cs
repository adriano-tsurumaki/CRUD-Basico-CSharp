using CRUD___Adriano.Features.Vendas.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class UcListaPagamento : UserControl
    {
        public UcListaPagamento()
        {
            InitializeComponent();
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
                DataPropertyName = "ValorAPagar",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
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
                    ForeColor = Color.Crimson,
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
            gridView.DataSource = listaFormaPagamento;
        }

        internal void Atualizar()
        {
            gridView.Refresh();
        }
    }
}
