using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.Vendas.Controller;
using CRUD___Adriano.Features.Vendas.Model;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class UcPesquisarProduto : UserControl
    {
        public delegate void PesquisarProdutoHandler(VendaProdutoModel vendaProdutoSelecionado);
        public event PesquisarProdutoHandler EventEnviarProduto;

        private readonly PesquisarProdutoController _controller;

        public UcPesquisarProduto(PesquisarProdutoController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void TxtPesquisar__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || txtPesquisar.NuloOuVazio()) return;

            EventEnviarProduto?.Invoke(new VendaProdutoModel { Nome = "ProdutoSendoPassado", PrecoVenda = 12.34f, Desconto = 5f, Quantidade = 1 });
        }
    }
}
