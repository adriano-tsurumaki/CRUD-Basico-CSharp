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

            DataGridViewTextBoxColumn precoColuna = new DataGridViewTextBoxColumn()
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

            gridView.Columns.Add(quantidadeColuna);
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
                e.Value = "-" + model.Desconto.Formatado;
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

            if (!(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn botao)) return;

            var vendaProdutoModel = gridView.CurrentRow.DataBoundItem as VendaProdutoModel;

            if (botao.Name.Equals("Incrementar"))
                vendaProdutoModel.Quantidade++;
            else if (botao.Name.Equals("Decrementar") && vendaProdutoModel.Quantidade > 1)
                vendaProdutoModel.Quantidade--;
            _controller.AtualizarSubTotal();
            gridView.Refresh();
        }

        private void GridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;

            if (senderGrid.Columns[e.ColumnIndex].Name != "Quantidade") return;

            _controller.AtualizarSubTotal();
        }

        private void GridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
