using CRUD___Adriano.Features.ValueObject.Precos;
using CRUD___Adriano.Features.Vendas.Controller;
using CRUD___Adriano.Features.Vendas.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class UcCarrinhoVenda : UserControl
    {
        private readonly CarrinhoVendaController _controller;
        private BindingList<VendaProdutoModel> _vendaProdutosBinding;

        public UcCarrinhoVenda(CarrinhoVendaController controller)
        {
            InitializeComponent();
            _controller = controller;

        }

        public void BindModel(BindingList<VendaProdutoModel> vendaProdutosBinding)
        {
            gridView.Columns.Clear();
            DataGridViewCell celula = new DataGridViewTextBoxCell();

            DataGridViewButtonColumn botaoDecrementar = new DataGridViewButtonColumn()
            {
                CellTemplate = new DataGridViewButtonCell(),
                HeaderText = "Decrementar",
                Name = "Decrementar",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.FromArgb(45, 66, 91),
                    SelectionBackColor = Color.LightSeaGreen,
                },
            };

            DataGridViewTextBoxColumn quantidadeColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnQuantidade",
                DataPropertyName = "Quantidade",
                DefaultCellStyle = new DataGridViewCellStyle 
                { 
                    Alignment = DataGridViewContentAlignment.MiddleCenter, 
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    BackColor = Color.FromArgb(45, 66, 91),
                    SelectionForeColor = Color.Black,
                    SelectionBackColor = Color.LightSeaGreen,
                },
                ReadOnly = true,
            };

            DataGridViewButtonColumn botaoIncrementar = new DataGridViewButtonColumn()
            {
                CellTemplate = new DataGridViewButtonCell(),
                HeaderText = "Incrementar",
                Name = "Incrementar",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.FromArgb(45, 66, 91),
                    SelectionBackColor = Color.LightSeaGreen,
                },
            };

            DataGridViewTextBoxColumn nomeColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnNome",
                DataPropertyName = "Nome",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle 
                { 
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    BackColor = Color.FromArgb(45, 66, 91),
                    SelectionForeColor = Color.Black,
                    SelectionBackColor = Color.LightSeaGreen,
                },
                ReadOnly = true,
            };

            DataGridViewTextBoxColumn descontoColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnDesconto",
                DataPropertyName = "Desconto.Formatado",
                DefaultCellStyle = new DataGridViewCellStyle 
                { 
                    Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point), 
                    ForeColor = Color.Crimson,
                    BackColor = Color.FromArgb(45, 66, 91),
                    SelectionBackColor = Color.LightSeaGreen,
                },
                ReadOnly = true,
            };

            DataGridViewTextBoxColumn precoColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnPrecaVenda",
                DataPropertyName = "PrecoVenda.Formatado",
                DefaultCellStyle = new DataGridViewCellStyle 
                { 
                    Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point), 
                    ForeColor = Color.DodgerBlue,
                    BackColor = Color.FromArgb(45, 66, 91),
                    SelectionBackColor = Color.LightSeaGreen,
                },
                ReadOnly = true,
            };

            gridView.Columns.Add(botaoDecrementar);
            gridView.Columns.Add(quantidadeColuna);
            gridView.Columns.Add(botaoIncrementar);
            gridView.Columns.Add(nomeColuna);
            gridView.Columns.Add(descontoColuna);
            gridView.Columns.Add(precoColuna);

            _vendaProdutosBinding = new BindingList<VendaProdutoModel>(vendaProdutosBinding);
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = vendaProdutosBinding;
            _controller.AtualizarSubTotal();
        }

        private void GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!(gridView.Rows[e.RowIndex].DataBoundItem is VendaProdutoModel model) || !gridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")) return;

            if (gridView.Columns[e.ColumnIndex].DataPropertyName == "Desconto.Formatado")
                e.Value = model.Desconto.Valor == 0 ? string.Empty : $"-{model.Desconto.Formatado}";
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

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;

            if (e.RowIndex < 0) return;

            if (!(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)) return;

            var botao = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            var vendaProdutoModel = gridView.CurrentRow.DataBoundItem as VendaProdutoModel;

            if (botao.Name.Equals("Incrementar"))
                vendaProdutoModel.Quantidade++;
            else if (botao.Name.Equals("Decrementar") && vendaProdutoModel.Quantidade > 1)
                vendaProdutoModel.Quantidade--;
            _controller.AtualizarSubTotal();
            gridView.Refresh();
        }
    }
}
