using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.Controller;
using CRUD___Adriano.Features.Utils;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.View
{
    public partial class FrmListagemCliente : Form
    {
        public BindingList<ClienteModel> _clientesBinding { get; set; }

        private ClienteListagemController _controller { get; set; }

        public FrmListagemCliente(ClienteListagemController controller)
        {
            InitializeComponent();
            _controller = controller;
            gridView.ConfiguracaoPadrao();
        }

        public void BindGrid(IList<ClienteModel> listaDeClientes)
        {
            gridView.Columns.Clear();
            DataGridViewCell celula = new DataGridViewTextBoxCell();

            gridView.TextBoxColumnPadrao(celula, "Id", "IdUsuario", true);
            gridView.TextBoxColumnPadrao(celula, "Nome", "Nome", true);
            gridView.ButtonColumnPadrao("Alterar");
            gridView.ButtonColumnPadrao("Excluir");

            _clientesBinding = new BindingList<ClienteModel>(listaDeClientes);
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = _clientesBinding;
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;

            if (e.RowIndex < 0) return;

            if (!(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn botao)) return;

            var clienteModelSelecionado = gridView.CurrentRow.DataBoundItem as ClienteModel;

            if (botao.Name.Equals("Excluir"))
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.No) return;

                if (_controller.ExcluirCliente(clienteModelSelecionado.IdUsuario))
                {
                    _clientesBinding.Remove(clienteModelSelecionado);
                    MessageBox.Show("Excluído com sucesso");
                }
            }
            else if (botao.Name.Equals("Alterar"))
                _controller.AlterarCliente(clienteModelSelecionado.IdUsuario);
        }

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;

            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) || 
                gridView.CurrentRow is null)
                return;

            var clienteModelSelecionado = gridView.CurrentRow.DataBoundItem as ClienteModel;

            _controller.AbrirFormDeDetalhes(clienteModelSelecionado.IdUsuario);
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
                _controller.ListarSomenteIdENome(_clientesBinding);
            else if (new Regex(@"^[%][0-9]+$").Match(txtPesquisar.Texto).Success)
            {
                var quantidade = txtPesquisar.Texto.RetornarSomenteTextoEmNumeros().IntOuZero();
                if (quantidade > 0)
                    _controller.ListarQuantidadeDeClientes(_clientesBinding, quantidade);
            }
            else if (txtPesquisar.Numerico())
                _controller.SelecionarPeloId(_clientesBinding, txtPesquisar.Texto.IntOuZero());
            else
                _controller.ListarPeloNomeSomenteIdENome(_clientesBinding, txtPesquisar.Texto);
        }
    }
}
