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
            gridView.Columns.Add(botaoAlterarColuna);
            gridView.Columns.Add(botaoExcluirColuna);

            _usuariosBinding = new BindingList<T>(listaDeUsuario);
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = _usuariosBinding;
        }
    }
}
