using CRUD___Adriano.Features.Produto.View;

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
    }
}
