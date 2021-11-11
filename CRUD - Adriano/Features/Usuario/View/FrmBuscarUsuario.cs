using CRUD___Adriano.Features.Usuario.Controller;
using CRUD___Adriano.Features.Usuario.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Usuario.View
{
    public partial class FrmBuscarUsuario<T> : Form where T : class
    {
        private readonly BuscarUsuarioController<T> _controller;
        private BindingList<T> _usuariosBinding;

        public FrmBuscarUsuario(BuscarUsuarioController<T> controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        public void DefinirNomePrevio(string nome) => txtPesquisar.Texto = nome;

        public void BindGrid(IList<T> listaDeUsuario)
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

            _usuariosBinding = new BindingList<T>(listaDeUsuario);
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = _usuariosBinding;
        }

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;

            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0) || gridView.CurrentRow == null)
                return;

            _controller.AtribuirUsuarioSelecionado(gridView.CurrentRow.DataBoundItem as T);
        }

        private void TxtPesquisar__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            _controller.ListarPeloNomeSomenteIdENome(txtPesquisar.Texto);
        }
    }
}
