using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.View;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Interface;

namespace CRUD___Adriano.Features.Cliente.Controller
{
    public class ClienteControllerPage : IControllerPage<ClienteModel>
    {
        private ClienteModel _clienteModel;

        private IViewPage<ClienteModel> _frmClientePage;

        public ClienteControllerPage()
        {
            _frmClientePage = new FrmCadastroCliente(this);
        }

        public IViewPage<ClienteModel> RetornarFormulario() => _frmClientePage;

        public void AdicionarModel(ref ClienteModel clienteModel)
        {
            _clienteModel = clienteModel;
            _frmClientePage.BindModel(ref clienteModel);
        }

        public bool ValidarForm() =>
            _frmClientePage.ValidarComponentes();
    }
}
