using CRUD___Adriano.Features.Produto.View;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.Controller
{
    public class ClienteListagemController
    {
        private FrmListagemCliente _frmListagemCliente;

        public ClienteListagemController()
        {
            _frmListagemCliente = new FrmListagemCliente(this);
        }

        public void AbrirFormulario() =>
            _frmListagemCliente.Show();

        public Form RetornarFormulario() =>
            _frmListagemCliente;
    }
}
