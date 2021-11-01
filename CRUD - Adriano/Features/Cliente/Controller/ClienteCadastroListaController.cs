using CRUD___Adriano.Features.Cliente.View;
using CRUD___Adriano.Features.Colaborador.Controller;
using CRUD___Adriano.Features.Configuration;
using CRUD___Adriano.Features.Factory;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.Controller
{
    public class ClienteCadastroListaController
    {
        private ClienteController _clienteController;
        private ColaboradorController _colaboradorController;
        private ControllerConexao _controllerConexao;

        public ClienteCadastroListaController(ControllerConexao controllerConexao)
        {
            _clienteController = new ClienteController(controllerConexao);
            _colaboradorController = new ColaboradorController(controllerConexao);
        }

        public Form RetornarFormulario() => new FrmCadastroListaDeClientes(this);

        public void CadastrarListaDeClientes(int quantidade)
        {
            if(_clienteController.SalvarLista(GerarUsuariosAleatoriamente.RetornarListaDeClientes(quantidade)))
                MessageBox.Show("Cadastrado com sucesso");
        }

        public void CadastrarListaDeColaboradores(int quantidade)
        {
            if(_colaboradorController.SalvarLista(GerarUsuariosAleatoriamente.RetornarListaDeColaboradores(quantidade)))
                MessageBox.Show("Cadastrado com sucesso");
        }
    }
}
