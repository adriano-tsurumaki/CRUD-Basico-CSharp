using CRUD___Adriano.Features.Cliente.Controller;
using CRUD___Adriano.Features.Cliente.View;
using CRUD___Adriano.Features.Colaborador.Controller;
using CRUD___Adriano.Features.Configuration;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Atalhos.Controller
{
    public class AtalhoController
    {
        private readonly ClienteController _clienteController;
        private readonly ColaboradorController _colaboradorController;

        public AtalhoController(ClienteController clienteController, ColaboradorController colaboradorController)
        {
            _clienteController = clienteController;
            _colaboradorController = colaboradorController;
        }

        public Form RetornarFormulario() => new FrmAtalhos(this);

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
