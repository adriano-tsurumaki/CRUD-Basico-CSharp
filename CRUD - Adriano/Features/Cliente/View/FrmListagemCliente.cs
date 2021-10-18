using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.Controller;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Produto.View
{
    public partial class FrmListagemCliente : Form
    {
        private ClienteListagemController _clienteListagemController;

        public FrmListagemCliente(ClienteListagemController clienteListagemController)
        {
            InitializeComponent();
            _clienteListagemController = clienteListagemController;
            gridView.DataSource = new List<ClienteModel>
            { 
                new ClienteModel
                {
                    Nome = "Produto 1",
                },
                new ClienteModel
                {
                    Nome = "Produto 2",
                },
            };
        }
    }
}
