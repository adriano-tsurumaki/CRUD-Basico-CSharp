using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cadastro.Usuario.View;
using CRUD___Adriano.Features.Cliente.View;
using CRUD___Adriano.Features.Controller.PageManager;
using CRUD___Adriano.Features.Usuario.View;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.Controller
{
    public class ClienteListagemController
    {
        private readonly Panel _dock;
        private ClienteController _clienteController;
        private FrmListagemCliente _frmListagemCliente;

        public ClienteListagemController(ClienteController clienteController)
        {
            ConfiguracaoInicial(clienteController);
        }

        public ClienteListagemController(ClienteController clienteController, Panel dock)
        {
            _dock = dock;
            ConfiguracaoInicial(clienteController);
        }

        public void ConfiguracaoInicial(ClienteController clienteController)
        {
            _clienteController = clienteController;
            _frmListagemCliente = new FrmListagemCliente(this);
            _frmListagemCliente.BindGrid(_clienteController.Listar());
        }

        public void AbrirFormDeDetalhes(ClienteModel clienteModel)
        {
            if (_dock == null)
            {
                new FrmDetalhesCliente(clienteModel).Show();
                return;
            }

            var frmAlterarCliente = new FrmDetalhesCliente(clienteModel)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            _dock.Controls.Add(frmAlterarCliente);
            _dock.Tag = frmAlterarCliente;

            frmAlterarCliente.BringToFront();
            frmAlterarCliente.Show();
        }

        public bool ExcluirCliente(int id) =>
            _clienteController.Remover(id);

        public Form RetornarFormulario() => _frmListagemCliente;

        public void AlterarCliente(ClienteModel clienteModel)
        {
            var pageManager = new GerenciadorDePaginas<ClienteModel>(
                _dock,
                _clienteController,
                clienteModel);

            pageManager.Add(new FrmCadastroUsuario<ClienteModel>());
            pageManager.Add(new FrmEmailTelefone<ClienteModel>());
            pageManager.Add(new FrmCadastroCliente());
            pageManager.Show();
        }
    }
}
