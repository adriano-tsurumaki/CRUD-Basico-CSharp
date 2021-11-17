using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.Vendas.Controller;
using CRUD___Adriano.Features.Vendas.Model;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class UcPesquisarProduto : UserControl
    {
        public delegate void PesquisarProdutoHandler(VendaProdutoModel vendaProdutoSelecionado);
        public event PesquisarProdutoHandler EventEnviarProduto;

        private readonly PesquisarProdutoController _controller;

        public UcPesquisarProduto(PesquisarProdutoController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void TxtPesquisar__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || txtPesquisar.NuloOuVazio()) return;

            PesquisarProduto();
        }

        private void BtnPesquisar_Click(object sender, System.EventArgs e)
        {
            if (txtPesquisar.NuloOuVazio()) return;
            
            PesquisarProduto();
        }

        private void PesquisarProduto()
        {
            VendaProdutoModel vendaProdutoModelSelecionado;

            if (txtPesquisar.Numerico())
                vendaProdutoModelSelecionado = _controller.PesquisarProdutoPeloId(txtPesquisar.Texto.IntOuZero());
            else if (txtPesquisar.Texto == "%")
            {
                gridView.DataSource = _controller.PesquisarTodosOsProdutos();
                return;
            }
            else
            {
                gridView.DataSource = _controller.PesquisarProdutoPeloNome(txtPesquisar.Texto);
                return;
            }

            if (vendaProdutoModelSelecionado.Vazio())
                EventEnviarProduto?.Invoke(vendaProdutoModelSelecionado);

            txtPesquisar.Texto = string.Empty;
        }

        private void GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!(gridView.Rows[e.RowIndex].DataBoundItem is VendaProdutoModel) || !gridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")) return;

            if (gridView.Columns[e.ColumnIndex].DataPropertyName == "PrecoVenda.Formatado")
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

        private void UcPesquisarProduto_Load(object sender, EventArgs e)
        {
            gridView.Columns.Clear();
            DataGridViewCell celula = new DataGridViewTextBoxCell();

            DataGridViewTextBoxColumn idColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnId",
                DataPropertyName = "Id",
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

            gridView.Columns.Add(idColuna);
            gridView.Columns.Add(nomeColuna);
            gridView.Columns.Add(precoColuna);

            gridView.AutoGenerateColumns = false;
        }

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridView.CurrentRow == null)
                return;

            var vendaProdutoModelSelecionado = _controller.PesquisarProdutoPeloId((gridView.CurrentRow.DataBoundItem as VendaProdutoModel).Id);

            if (vendaProdutoModelSelecionado.Vazio())
                EventEnviarProduto?.Invoke(vendaProdutoModelSelecionado);

            txtPesquisar.Texto = string.Empty;
        }

        private void UcPesquisarProduto_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
