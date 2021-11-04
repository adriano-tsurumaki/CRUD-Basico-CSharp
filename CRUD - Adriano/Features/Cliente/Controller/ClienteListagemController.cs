﻿using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.View;
using CRUD___Adriano.Features.Controller.PageManager;
using CRUD___Adriano.Features.Usuario.Controller;
using Ninject;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
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

        public void AlterarCliente(int id)
        {
            var clienteModelSelecionado = _clienteController.Selecionar(id);
            
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var pageManager = new GerenciadorDePaginas<ClienteModel>(
                _dock,
                _clienteController,
                clienteModelSelecionado);

            pageManager.Add(kernel.Get<UsuarioControllerPage<ClienteModel>>());
            pageManager.Add(kernel.Get<EmailTelefoneControllerPage<ClienteModel>>());
            pageManager.Add(kernel.Get<ClienteControllerPage>());
            pageManager.SetConfirm(Factory.ControllerEnum.Atualizar);
            pageManager.Show();
        }

        public void ListarTodosOsClientes(BindingList<ClienteModel> clientesBinding)
        {
            clientesBinding.Clear();
            foreach (var clienteModel in _clienteController.ListarSomenteIdENome())
                clientesBinding.Add(clienteModel);
        }

        public void ListarQuantidadeDeClientes(BindingList<ClienteModel> clientesBinding, int quantidade)
        {
            clientesBinding.Clear();
            foreach (var clienteModel in _clienteController.ListarPelaQuantidadeSomenteIdENome(quantidade))
                clientesBinding.Add(clienteModel);
        }

        public void SelecionarPeloId(BindingList<ClienteModel> clientesBinding, int id)
        {
            clientesBinding.Clear();
            var clienteModel = _clienteController.SelecionarSomenteIdENome(id);
            if (clienteModel == null) return;

            clientesBinding.Add(clienteModel);
        }

        public void ListarPeloNomeSomenteIdENome(BindingList<ClienteModel> clientesBinding, string nome)
        {
            clientesBinding.Clear();
            foreach (var clienteModel in _clienteController.ListarPeloNomeSomenteIdENome(nome))
                clientesBinding.Add(clienteModel);
        }
    }
}
