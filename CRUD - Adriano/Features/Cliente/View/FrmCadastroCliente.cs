using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.View
{
    public partial class FrmCadastroCliente : FormBase<ClienteModel>
    {
        private ClienteModel _clienteModel;

        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        public override void AdicionarModel(ClienteModel clienteModel)
        {
            _clienteModel = clienteModel;
        }
    }
}
