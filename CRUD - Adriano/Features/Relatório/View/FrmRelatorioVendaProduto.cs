using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Relatório.Controller;
using CRUD___Adriano.Features.Usuario.Controller;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Relatório.View
{
    public partial class FrmRelatorioVendaProduto : Form
    {
        private readonly RelatorioVendaProdutoController _controller;

        public FrmRelatorioVendaProduto(RelatorioVendaProdutoController controller)
        {
            InitializeComponent();
            _controller = controller;
            gridView.DataSource = _controller.ListarTodosProdutosPeloFiltro();
        }

        private void BtnPesquisarProduto_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnDeselecionarProduto_Click(object sender, System.EventArgs e)
        {
            txtProduto.Text = "Não selecionado";
            _controller.DefinirIdProdutoNoFiltro(0);
        }

        private void BtnPesquisarCliente_Click(object sender, System.EventArgs e)
        {
            var clienteModel = ConfigNinject.ObterInstancia<BuscarUsuarioController<ClienteModel>>()
                .DefinirTituloDoForm("Listagem de Clientes").RetornarUsuarioSelecionado();

            txtCliente.Text = clienteModel.Nome;
            _controller.DefinirIdClienteNoFiltro(clienteModel.IdUsuario);
        }

        private void BtnDeselecionarCliente_Click(object sender, System.EventArgs e)
        {
            txtCliente.Text = "Não selecionado";
            _controller.DefinirIdClienteNoFiltro(0);
        }

        private void BtnFiltrar_Click(object sender, System.EventArgs e)
        {
            gridView.DataSource = _controller.ListarTodosProdutosPeloFiltro();
        }
    }
}
