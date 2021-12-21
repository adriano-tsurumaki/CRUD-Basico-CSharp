using CRUD___Adriano.Features.Usuario.Controller;
using CRUD___Adriano.Features.Utils;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Usuario.View
{
    public partial class FrmBuscarUsuario<T> : Form where T : class, new()
    {
        private readonly BuscarUsuarioController<T> _controller;
        private BindingList<T> _usuariosBinding;

        public FrmBuscarUsuario(BuscarUsuarioController<T> controller)
        {
            InitializeComponent();
            _controller = controller;
            gridView.ConfiguracaoPadrao();
            gridView.ConfiguracaoHeaderPadrao();
        }

        public void DefinirNomePrevio(string nome)
        {
            txtPesquisar.Texto = nome;
            PesquisarDeAcordoComOTexto();
        }

        public void DefinirTituloDoForm(string nome)
        {
            Text = nome;
            lblTitulo.Text = nome;
        }

        public void BindGrid(BindingList<T> usuariosBinding)
        {
            gridView.Columns.Clear();
            DataGridViewCell celula = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn idColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnId",
                HeaderText = "Id",
                DataPropertyName = "IdUsuario",
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

            gridView.Columns.Add(idColuna);
            gridView.Columns.Add(nomeColuna);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = _usuariosBinding = usuariosBinding;
        }

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;

            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0) || gridView.CurrentRow == null)
                return;

            _controller.AtribuirUsuarioSelecionado(gridView.CurrentRow.DataBoundItem as T);
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
                _controller.ListarSomenteIdENome(_usuariosBinding);
            else if (new Regex(@"^[%][0-9]+$").Match(txtPesquisar.Texto).Success)
            {
                var quantidade = txtPesquisar.Texto.RetornarSomenteTextoEmNumeros().IntOuZero();
                if (quantidade > 0)
                    _controller.ListarPorQuantidade(_usuariosBinding, quantidade);
            }
            else if (txtPesquisar.Numerico())
                _controller.SelecionarPeloId(_usuariosBinding, txtPesquisar.Texto.IntOuZero());
            else
                _controller.ListarPeloNomeSomenteIdENome(_usuariosBinding, txtPesquisar.Texto);
        }
    }
}
