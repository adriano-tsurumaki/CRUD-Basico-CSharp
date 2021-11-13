using CRUD___Adriano.Features.ValueObject.Precos;
using CRUD___Adriano.Features.Vendas.Controller;
using CRUD___Adriano.Features.Vendas.Model;
using System;
using System.ComponentModel;
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
                Name = "Decrementar"
            };

            DataGridViewTextBoxColumn quantidadeColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnQuantidade",
                DataPropertyName = "Quantidade",
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point) },
                ReadOnly = true,
            };

            DataGridViewButtonColumn botaoIncrementar = new DataGridViewButtonColumn()
            {
                CellTemplate = new DataGridViewButtonCell(),
                HeaderText = "Incrementar",
                Name = "Incrementar",
            };

            DataGridViewTextBoxColumn nomeColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnNome",
                DataPropertyName = "Nome",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle { Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point) },

                ReadOnly = true,
            };

            DataGridViewTextBoxColumn descontoColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnDesconto",
                DataPropertyName = "Desconto.Formatado",
                DefaultCellStyle = new DataGridViewCellStyle { Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point), ForeColor = System.Drawing.Color.Crimson },
                ReadOnly = true,
            };

            DataGridViewTextBoxColumn precoColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnPrecaVenda",
                DataPropertyName = "PrecoVenda.Formatado",
                DefaultCellStyle = new DataGridViewCellStyle 
                { 
                    Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point), 
                    ForeColor = System.Drawing.Color.DodgerBlue,
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
            if ((gridView.Rows[e.RowIndex].DataBoundItem != null) && (gridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                if(gridView.Columns[e.ColumnIndex].DataPropertyName == "Desconto.Formatado")
                    e.Value = "-" + BindProperty(gridView.Rows[e.RowIndex].DataBoundItem, gridView.Columns[e.ColumnIndex].DataPropertyName);
                else
                    e.Value = BindProperty(gridView.Rows[e.RowIndex].DataBoundItem, gridView.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        private object BindProperty(object property, string propertyName)
        {
            string retValue = "";
            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;
                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();
                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = (string)BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;
                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }
            return retValue;
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
