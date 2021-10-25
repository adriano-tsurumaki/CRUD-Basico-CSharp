﻿using CRUD___Adriano.Features.Cadastro.Usuario.View;
using CRUD___Adriano.Features.Cliente.Model;
using CRUD___Adriano.Features.Colaborador.View;
using CRUD___Adriano.Features.Controller.PageManager;
using CRUD___Adriano.Features.Usuario.View;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Colaborador.Controller
{
    public class ColaboradorListagemController
    {
        private readonly Panel _dock;
        private ColaboradorController _colaboradorController;
        private FrmListagemColaborador _frmListagemColaborador;

        public ColaboradorListagemController(ColaboradorController colaboradorController)
        {
            ConfiguracaoInicial(colaboradorController);
        }

        public ColaboradorListagemController(ColaboradorController colaboradorController, Panel dock)
        {
            _dock = dock;
            ConfiguracaoInicial(colaboradorController);
        }

        public void ConfiguracaoInicial(ColaboradorController colaboradorController)
        {
            _colaboradorController = colaboradorController;
            _frmListagemColaborador = new FrmListagemColaborador(this);
            _frmListagemColaborador.BindGrid(colaboradorController.Listar());
        }

        public bool ExcluirCliente(int id) =>
            _colaboradorController.Remover(id);

        public Form RetornarFormulario() => _frmListagemColaborador;

        public void AlterarCliente(ColaboradorModel clienteModelSelecionado)
        {
            var pageManager = new GerenciadorDePaginas<ColaboradorModel>(
                _dock,
                _colaboradorController,
                clienteModelSelecionado);

            pageManager.Add(new FrmCadastroUsuario<ColaboradorModel>());
            pageManager.Add(new FrmEmailTelefone<ColaboradorModel>());
            pageManager.Add(new FrmCadastroColaborador());
            pageManager.SetConfirm(Factory.ControllerEnum.Atualizar);
            pageManager.Show();
        }

        public void AbrirFormDeDetalhes(ColaboradorModel colaboradorModelSelecionado)
        {
            if (_dock == null)
            {
                new FrmDetalhesColaborador(colaboradorModelSelecionado).Show();
                return;
            }

            var frmAlterarColaborador = new FrmDetalhesColaborador(colaboradorModelSelecionado)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            _dock.Controls.Add(frmAlterarColaborador);
            _dock.Tag = frmAlterarColaborador;

            frmAlterarColaborador.BringToFront();
            frmAlterarColaborador.Show();
        }
    }
}
