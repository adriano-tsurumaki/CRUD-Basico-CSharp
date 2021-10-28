using CRUD___Adriano.Features.Cliente.Controller;
using CRUD___Adriano.Features.Cliente.Dao;
using CRUD___Adriano.Features.Cliente.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.Controller
{
    public class ClienteCadastroListaController
    {
        private ClienteController _clienteController;

        public ClienteCadastroListaController(ClienteController clienteController)
        {
            _clienteController = clienteController;
        }

        public Form RetornarFormulario() => new FrmCadastroListaDeClientes(this);

        public void CadastrarLista(int quantidade) =>
            _clienteController.SalvarLista(GerarClienteRandomico.RetornarListaDeClientes(quantidade));
    }
}
