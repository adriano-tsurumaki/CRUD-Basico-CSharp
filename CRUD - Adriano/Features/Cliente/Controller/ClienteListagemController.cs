using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.Dao;
using CRUD___Adriano.Features.Cliente.View;
using CRUD___Adriano.Features.Controller.PageManager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.Controller
{
    public class ClienteListagemController
    {
        private Panel _dock;
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

            var frmAlterarCliente = new FrmDetalhesCliente(clienteModel);
            frmAlterarCliente.TopLevel = false;
            frmAlterarCliente.FormBorderStyle = FormBorderStyle.None;
            frmAlterarCliente.Dock = DockStyle.Fill;
            _dock.Controls.Add(frmAlterarCliente);
            _dock.Tag = frmAlterarCliente;

            frmAlterarCliente.BringToFront();
            frmAlterarCliente.Show();
        }

        public Form RetornarFormulario() => _frmListagemCliente;
    }
}
