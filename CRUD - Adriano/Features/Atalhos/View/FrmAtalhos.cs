using CRUD___Adriano.Features.Atalhos.Controller;
using CRUD___Adriano.Features.Utils;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.View
{
    public partial class FrmAtalhos : Form
    {
        private readonly AtalhoController _controller;
        
        public FrmAtalhos(AtalhoController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void TxtQuantidadeClientes__TextChanged(object sender, System.EventArgs e) =>
            txtQuantidadeClientes.Texto = txtQuantidadeClientes.Texto.RetornarSomenteTextoEmNumeros();

        private void TxtQuantidadeClientes__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            CadastrarClientes();
        }

        private void BtnCadastrarClientes_Click(object sender, System.EventArgs e) =>
            CadastrarClientes();

        private void CadastrarClientes()
        {
            if (txtQuantidadeClientes.NuloOuVazio())
                return;

            int.TryParse(txtQuantidadeClientes.Texto, out int quantidade);
            _controller.CadastrarListaDeClientes(quantidade);
        }

        private void TxtQuantidadeColaboradores__TextChanged(object sender, System.EventArgs e) =>
            txtQuantidadeColaboradores.Texto = txtQuantidadeColaboradores.Texto.RetornarSomenteTextoEmNumeros();

        private void TxtQuantidadeColaboradores__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            CadastrarColaboradores();
        }

        private void BtnCadastrarColaboradores_Click(object sender, System.EventArgs e) =>
            CadastrarColaboradores();

        private void CadastrarColaboradores()
        {
            if (txtQuantidadeColaboradores.NuloOuVazio())
                return;

            _controller.CadastrarListaDeColaboradores(txtQuantidadeColaboradores.Texto.IntOuZero());
        }

        private void TxtQuantidadeFornecedores__TextChanged(object sender, System.EventArgs e) =>
            txtQuantidadeFornecedores.Texto = txtQuantidadeFornecedores.Texto.RetornarSomenteTextoEmNumeros();

        private void TxtQuantidadeFornecedores__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            CadastrarFornecedores();
        }

        private void BtnCadastrarFornecedores_Click(object sender, System.EventArgs e) =>
            CadastrarFornecedores();

        private void CadastrarFornecedores()
        {
            if (txtQuantidadeFornecedores.NuloOuVazio())
                return;

            _controller.CadastrarListaDeFornecedores(txtQuantidadeFornecedores.Texto.IntOuZero());
        }

        private void TxtQuantidadeProdutos__TextChanged(object sender, System.EventArgs e) =>
            txtQuantidadeProdutos.Texto = txtQuantidadeProdutos.Texto.RetornarSomenteTextoEmNumeros();

        private void TxtQuantidadeProdutos__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            CadastrarProdutos();
        }

        private void BtnCadastrarProdutos_Click(object sender, System.EventArgs e) =>
            CadastrarProdutos();

        private void CadastrarProdutos()
        {
            if (txtQuantidadeProdutos.NuloOuVazio())
                return;

            _controller.CadastrarListaDeProdutos(txtQuantidadeProdutos.Texto.IntOuZero());
        }
    }
}
