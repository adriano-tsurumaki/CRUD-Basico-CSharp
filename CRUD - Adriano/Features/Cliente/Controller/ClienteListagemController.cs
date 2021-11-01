using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cadastro.Usuario.View;
using CRUD___Adriano.Features.Cliente.View;
using CRUD___Adriano.Features.Controller.PageManager;
using CRUD___Adriano.Features.Usuario.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            _frmListagemCliente.BindGrid(new List<ClienteModel>());
        }

        public void AbrirFormDeDetalhes(int id)
        {
            var clienteModelSelecionado = _clienteController.Selecionar(id);
            
            if (_dock == null)
            {
                new FrmDetalhesCliente(clienteModelSelecionado).Show();
                return;
            }

            var frmAlterarCliente = new FrmDetalhesCliente(clienteModelSelecionado)
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

        public void AlterarCliente(ClienteModel clienteModelSelecionado)
        {
            var pageManager = new GerenciadorDePaginas<ClienteModel>(
                _dock,
                _clienteController,
                clienteModelSelecionado);

            pageManager.Add(new FrmCadastroUsuario<ClienteModel>());
            pageManager.Add(new FrmEmailTelefone<ClienteModel>());
            pageManager.Add(new FrmCadastroCliente());
            pageManager.SetConfirm(Factory.ControllerEnum.Atualizar);
            pageManager.Show();
        }

        public void ListarTodosOsClientes(BindingList<ClienteModel> clientesBinding)
        {
            clientesBinding.Clear();
            foreach (var clienteModel in _clienteController.ListarSomenteIdENome())
                clientesBinding.Add(clienteModel);
        }

        public void ListarPeloNomeSomenteIdENome(BindingList<ClienteModel> clientesBinding, string nome)
        {
            clientesBinding.Clear();
            foreach(var clienteModel in _clienteController.ListarPeloNomeSomenteIdENome(nome))
                clientesBinding.Add(clienteModel);
        }

        public void ListarQuantidadeDeClientes(BindingList<ClienteModel> clientesBinding, int quantidade)
        {
            clientesBinding.Clear();
            foreach (var clienteModel in _clienteController.Listar(quantidade))
                clientesBinding.Add(clienteModel);
        }

        public void SelecionarPeloId(BindingList<ClienteModel> clientesBinding, int id)
        {
            clientesBinding.Clear();
            var cliente = _clienteController.SelecionarSomenteIdENome(id);
            if (cliente == null) return;

            clientesBinding.Add(cliente);
        }
    }
}
