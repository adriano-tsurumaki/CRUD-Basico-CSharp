using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.Controller;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.View
{
    public partial class FrmListagemCliente : Form
    {
        public ClienteListagemController _controller { get; set; }
        public FrmListagemCliente(ClienteListagemController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        public void BindGrid(IList<ClienteModel> listaDeClientes)
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

            var listaDeClientesBinding = new BindingList<ClienteModel>(listaDeClientes);
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = listaDeClientesBinding;
        }

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var clienteModelSelecionado = gridView.CurrentRow.DataBoundItem as ClienteModel;

            _controller.AbrirFormDeDetalhes(clienteModelSelecionado);
        }
    }
}
