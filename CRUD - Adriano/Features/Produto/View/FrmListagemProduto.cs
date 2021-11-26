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
        }

        internal void BindGrid(List<ProdutoModel> listaDeProdutos)
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

            DataGridViewTextBoxColumn nomeColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnNome",
                HeaderText = "Nome",
                DataPropertyName = "Nome",
                ReadOnly = true,
            };

            DataGridViewTextBoxColumn quantidadeColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnQuantidade",
                HeaderText = "Quantidade",
                DataPropertyName = "Quantidade",
                ReadOnly = true,
            };

            DataGridViewTextBoxColumn ativoColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnAtivo",
                HeaderText = "Ativo",
                DataPropertyName = "Ativo",
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
            gridView.Columns.Add(nomeColuna);
            gridView.Columns.Add(quantidadeColuna);
            gridView.Columns.Add(ativoColuna);
            gridView.Columns.Add(botaoAlterarColuna);
            gridView.Columns.Add(botaoExcluirColuna);

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

            if (botao.Name.Equals("Excluir"))
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.No) return;

                if (_controller.ExcluirProduto(produtoModelSelecionado.Id))
                {
                    _produtosBinding.Remove(produtoModelSelecionado);
                    MessageBox.Show("Excluído com sucesso");
                }
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
    }
}
