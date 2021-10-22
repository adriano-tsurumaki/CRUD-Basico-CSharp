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
        private Panel _dock;
        private ClienteController _clienteController;

        public FrmListagemCliente(ClienteController clienteController)
        {
            InitializeComponent();
            _clienteController = clienteController;
            BindGrid();
        }

        public FrmListagemCliente(ClienteController clienteController, Panel dock)
        {
            InitializeComponent();
            _dock = dock;
            _clienteController = clienteController;
            BindGrid();
        }

        private void BindGrid()
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

            var listaDeClientes = new BindingList<ClienteModel>(_clienteController.Listar());
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = listaDeClientes;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (_dock == null)
            {
                new FrmAlterarCliente().Show();
                return;
            }

            FrmAlterarCliente frmAlterarCliente = new FrmAlterarCliente();
            frmAlterarCliente.TopLevel = false;
            frmAlterarCliente.FormBorderStyle = FormBorderStyle.None;
            frmAlterarCliente.Dock = DockStyle.Fill;
            _dock.Controls.Add(frmAlterarCliente);
            _dock.Tag = frmAlterarCliente;

            frmAlterarCliente.BringToFront();
            frmAlterarCliente.Show();
        }

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var clienteModelSelecionado = gridView.CurrentRow.DataBoundItem as ClienteModel;


        }
    }
}
