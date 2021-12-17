using CRUD___Adriano.Features.Produto.Controller;
using CRUD___Adriano.Features.Produto.Model;
using CRUD___Adriano.Features.Utils;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Produto.View
{
    public partial class FrmListagemProduto : Form
    {
        private readonly ProdutoListagemController _controller;
        private BindingList<ProdutoModel> _produtosBinding;

        public FrmListagemProduto(Controller.ProdutoListagemController controller)
        {
            InitializeComponent();
            _controller = controller;
            gridView.ConfiguracaoHeaderPadrao();
            gridView.ConfiguracaoPadrao();
        }

        internal void BindGrid(List<ProdutoModel> listaDeProdutos)
        {
            gridView.Columns.Clear();
            DataGridViewCell celula = new DataGridViewTextBoxCell();

            gridView.TextBoxColumnPadrao(celula, "Id", "Id", true); 
            gridView.TextBoxColumnPadrao(celula, "Nome", "Nome", true); 
            gridView.TextBoxColumnPadrao(celula, "Quantidade", "Quantidade", true); 
            gridView.TextBoxColumnPadrao(celula, "Status", "Ativo", true); 
            gridView.ButtonColumnPadrao("Alterar"); 
            gridView.ButtonColumnPadrao("Ativar/Inativar"); 

            _produtosBinding = new BindingList<ProdutoModel>(listaDeProdutos);
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = _produtosBinding;
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;

            if (e.RowIndex < 0) return;

            if (!(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn botao)) return;

            var produtoModelSelecionado = gridView.CurrentRow.DataBoundItem as ProdutoModel;

            if (botao.Name.Equals("Ativar/Inativar"))
            {
                if (MessageBox.Show("Deseja realmente ativar/inativar?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.No) return;

                if (_controller.TrocarStatusDoProduto(produtoModelSelecionado.Id))
                    MessageBox.Show("Sucesso");
            }
            else if (botao.Name.Equals("Alterar"))
                _controller.AlterarProduto(produtoModelSelecionado.Id);
        }

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;

            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0) || gridView.CurrentRow == null)
                return;

            var produtoModelSelecionado = gridView.CurrentRow.DataBoundItem as ProdutoModel;

            _controller.AbrirFormDeDetalhes(produtoModelSelecionado.Id);
        }

        private void BtnPesquisar_Click(object sender, System.EventArgs e) =>
            PesquisarDeAcordoComOTexto();


        private void TxtPesquisar__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            PesquisarDeAcordoComOTexto();
        }

        private void PesquisarDeAcordoComOTexto()
        {
            if (txtPesquisar.NuloOuVazio())
                return;
            else if (txtPesquisar.Texto == "%")
                _controller.ListarSomenteIdENome(_produtosBinding);
            else if (new Regex(@"^[%][0-9]+$").Match(txtPesquisar.Texto).Success)
            {
                var quantidade = txtPesquisar.Texto.RetornarSomenteTextoEmNumeros().IntOuZero();
                if (quantidade > 0)
                    _controller.ListarQuantidadeDeClientes(_produtosBinding, quantidade);
            }
            else if (txtPesquisar.Numerico())
                _controller.SelecionarPeloId(_produtosBinding, txtPesquisar.Texto.IntOuZero());
            else
                _controller.ListarPeloNomeSomenteIdENome(_produtosBinding, txtPesquisar.Texto);
        }

        private void GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!(gridView.Rows[e.RowIndex].DataBoundItem is ProdutoModel model)) return;

            if (gridView.Columns[e.ColumnIndex].DataPropertyName == "Ativo")
                e.Value = model.Ativo ? "Ativo" : "Inativo";
        }
    }
}
