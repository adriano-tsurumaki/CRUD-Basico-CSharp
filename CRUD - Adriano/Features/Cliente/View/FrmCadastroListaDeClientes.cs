using CRUD___Adriano.Features.Cliente.Controller;
using CRUD___Adriano.Features.Utils;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.View
{
    public partial class FrmCadastroListaDeClientes : Form
    {
        private readonly ClienteCadastroListaController _controller;
        
        public FrmCadastroListaDeClientes(ClienteCadastroListaController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void BtnCadastrar_Click(object sender, System.EventArgs e) =>
            CadastrarClientes();

        private void TxtQuantidade__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            CadastrarClientes();
        }

        private void CadastrarClientes()
        {
            if (txtQuantidade.NuloOuVazio())
                return;

            int.TryParse(txtQuantidade.Texto, out int quantidade);
            _controller.CadastrarLista(quantidade);
        }

        private void TxtQuantidade__TextChanged(object sender, System.EventArgs e) =>
            txtQuantidade.Texto = txtQuantidade.Texto.RetornarSomenteTextoEmNumeros();
    }
}
