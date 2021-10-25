﻿using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.Controller;
using System.Collections.Generic;
using System.ComponentModel;
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

            _clientesBinding = new BindingList<ClienteModel>(listaDeClientes);
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = _clientesBinding;
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;

            if (e.RowIndex < 0) return;

            if (!(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)) return;

            var botao = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            var clienteModelSelecionado = gridView.CurrentRow.DataBoundItem as ClienteModel;

            if (botao.Name.Equals("Excluir"))
            {
                if (_controller.ExcluirCliente(clienteModelSelecionado.IdUsuario))
                {
                    _clientesBinding.Remove(clienteModelSelecionado);
                    MessageBox.Show("Excluído com sucesso");
                }
            }
            else if (botao.Name.Equals("Alterar"))
                _controller.AlterarCliente(clienteModelSelecionado);
        }

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                return;

            var clienteModelSelecionado = gridView.CurrentRow.DataBoundItem as ClienteModel;

            _controller.AbrirFormDeDetalhes(clienteModelSelecionado);
        }
    }
}
