using CRUD___Adriano.Features.Vendas.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class FrmDetalhesVenda : Form
    {
        public FrmDetalhesVenda(VendaModel vendaModel)
        {
            InitializeComponent();
            AtribuirModelParaCampo(vendaModel);
        }

        private void AtribuirModelParaCampo(VendaModel vendaModel)
        {
            lblNumeroVenda.Text = vendaModel.Id.ToString();
            lblNomeVendedor.Text = vendaModel.Colaborador.Nome;
            lblNomeCliente.Text = vendaModel.Cliente.Nome;
            lblLucroTotal.Text = vendaModel.ListaDeProdutos.Sum(x => x.Lucro).ToString("c");
            lblDataEmissao.Text = vendaModel.DataEmissao.ToString("dd/MM/yyyy");
            lblDescontoTotal.Text = vendaModel.DescontoTotal.Formatado;
            lblValorBrutoTotal.Text = vendaModel.ValorBrutoTotal.Formatado;
            lblValorPago.Text = vendaModel.ValorPago.Formatado;

            ConfiguracaoGridViewProdutos(vendaModel.ListaDeProdutos);
            ConfiguracaoGridViewPagamentos(vendaModel.ListaPagamentos);
        }

        private void ConfiguracaoGridViewProdutos(IList<VendaProdutoModel> listaDeProdutos)
        {
            gridViewProdutos.Columns.Clear();
            DataGridViewCell celula = new DataGridViewTextBoxCell();

            DataGridViewTextBoxColumn quantidadeColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "Quantidade",
                DataPropertyName = "Quantidade",
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

            DataGridViewTextBoxColumn nomeColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "Nome",
                DataPropertyName = "Nome",
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

            DataGridViewTextBoxColumn descontoColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "Desconto",
                DataPropertyName = "Desconto.Formatado",
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

            DataGridViewTextBoxColumn precoVendaColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "Preço de venda",
                DataPropertyName = "PrecoVenda.Formatado",
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

            DataGridViewTextBoxColumn precoLiquidoColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "Preço líquido",
                DataPropertyName = "PrecoLiquido.Formatado",
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

            gridViewProdutos.Columns.Add(quantidadeColuna);
            gridViewProdutos.Columns.Add(nomeColuna);
            gridViewProdutos.Columns.Add(descontoColuna);
            gridViewProdutos.Columns.Add(precoVendaColuna);
            gridViewProdutos.Columns.Add(precoLiquidoColuna);



            gridViewProdutos.AutoGenerateColumns = false;
            gridViewProdutos.DataSource = listaDeProdutos;
        }

        private void ConfiguracaoGridViewPagamentos(IList<FormaPagamentoModel> listaDePagamentos)
        {
            gridViewPagamentos.Columns.Clear();
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

            gridViewPagamentos.Columns.Add(posicaoColuna);
            gridViewPagamentos.Columns.Add(valorAPagarColuna);
            gridViewPagamentos.Columns.Add(tipoPagamentoColuna);
            gridViewPagamentos.Columns.Add(quantidadeParcelasColuna);
            gridViewPagamentos.Columns.Add(posicaoParcelaColuna);

            gridViewPagamentos.AutoGenerateColumns = false;
            gridViewPagamentos.DataSource = listaDePagamentos;

        }

        private void FrmDetalhesVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape) return;

            Close();
        }

        private void BtnFechar_Click(object sender, System.EventArgs e) =>
            Close();

        private void GridViewProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!(gridViewProdutos.Rows[e.RowIndex].DataBoundItem is VendaProdutoModel model) || !gridViewProdutos.Columns[e.ColumnIndex].DataPropertyName.Contains(".")) return;

            if (gridViewProdutos.Columns[e.ColumnIndex].DataPropertyName == "Desconto.Formatado")
                e.Value = "-" + model.Desconto.Formatado;
            else
                e.Value = BindProperty(gridViewProdutos.Rows[e.RowIndex].DataBoundItem, gridViewProdutos.Columns[e.ColumnIndex].DataPropertyName);
        }

        private void GridViewPagamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.Value = BindProperty(gridViewPagamentos.Rows[e.RowIndex].DataBoundItem, gridViewPagamentos.Columns[e.ColumnIndex].DataPropertyName);
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
    }
}
