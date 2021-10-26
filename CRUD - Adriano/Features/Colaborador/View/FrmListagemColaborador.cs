﻿using CRUD___Adriano.Features.Cliente.Model;
using CRUD___Adriano.Features.Colaborador.Controller;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Colaborador.View
{
    public partial class FrmListagemColaborador : Form
    {
        private BindingList<ColaboradorModel> _colaboradoresBinding;
        private ColaboradorListagemController _controller { get; set; }

        public FrmListagemColaborador(ColaboradorListagemController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        public void BindGrid(IList<ColaboradorModel> listaDeClientes)
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

            _colaboradoresBinding = new BindingList<ColaboradorModel>(listaDeClientes);
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = _colaboradoresBinding;
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;

            if (e.RowIndex < 0) return;

            if (!(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)) return;

            var botao = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            var colaboradorModelSelecionado = gridView.CurrentRow.DataBoundItem as ColaboradorModel;

            if (botao.Name.Equals("Excluir"))
            {
                if (_controller.ExcluirCliente(colaboradorModelSelecionado.IdUsuario))
                {
                    _colaboradoresBinding.Remove(colaboradorModelSelecionado);
                    MessageBox.Show("Excluído com sucesso");
                }
            }
            else if (botao.Name.Equals("Alterar"))
                _controller.AlterarCliente(colaboradorModelSelecionado);
        }

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                return;

            var colaboradorModelSelecionado = gridView.CurrentRow.DataBoundItem as ColaboradorModel;

            _controller.AbrirFormDeDetalhes(colaboradorModelSelecionado);
        }
    }
}