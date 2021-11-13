using CRUD___Adriano.Features.Vendas.Controller;
using CRUD___Adriano.Features.Vendas.Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class UcCarrinhoVenda : UserControl
    {
        private readonly CarrinhoVendaController _controller;
        private BindingList<VendaProdutoModel> _vendaProdutosBinding;

        public UcCarrinhoVenda(CarrinhoVendaController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        public void BindModel(BindingList<VendaProdutoModel> vendaProdutosBinding)
        {
            gridView.Columns.Clear();
            DataGridViewCell celula = new DataGridViewTextBoxCell();

            DataGridViewTextBoxColumn nomeColuna = new DataGridViewTextBoxColumn()
            {
                CellTemplate = celula,
                Name = "clnNome",
                HeaderText = "Nome",
                DataPropertyName = "Nome",
                ReadOnly = true,
            };

            gridView.Columns.Add(nomeColuna);

            _vendaProdutosBinding = new BindingList<VendaProdutoModel>(vendaProdutosBinding);
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = vendaProdutosBinding;
        }
    }
}
