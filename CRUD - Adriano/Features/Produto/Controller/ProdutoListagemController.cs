using CRUD___Adriano.Features.Controller.PageManager;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Produto.Model;
using CRUD___Adriano.Features.Produto.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Produto.Controller
{
    public class ProdutoListagemController
    {
        private readonly Panel _dock;
        private readonly ProdutoController _produtoController;
        private readonly FrmListagemProduto _frmListagemProduto;

        public ProdutoListagemController(ProdutoController produtoController, Panel dock)
        {
            _dock = dock;
            _produtoController = produtoController;
            _frmListagemProduto = new FrmListagemProduto(this);
            _frmListagemProduto.BindGrid(new List<ProdutoModel>());
        }

        public FrmListagemProduto RetornarFormulario() => _frmListagemProduto;

        public void ListarSomenteIdENome(BindingList<ProdutoModel> produtosBinding)
        {
            produtosBinding.Clear();
            foreach (var clienteModel in _produtoController.ListarSomenteIdENome())
                produtosBinding.Add(clienteModel);
        }

        public void ListarQuantidadeDeClientes(BindingList<ProdutoModel> produtosBinding, int quantidade)
        {
            produtosBinding.Clear();
            foreach (var clienteModel in _produtoController.ListarPelaQuantidadeSomenteIdENome(quantidade))
                produtosBinding.Add(clienteModel);
        }

        public void SelecionarPeloId(BindingList<ProdutoModel> produtosBinding, int id)
        {
            produtosBinding.Clear();
            var clienteModel = _produtoController.SelecionarPeloIdSomenteIdENome(id);
            if (clienteModel == null) return;

            produtosBinding.Add(clienteModel);
        }

        public void ListarPeloNomeSomenteIdENome(BindingList<ProdutoModel> produtosBinding, string nome)
        {
            produtosBinding.Clear();
            foreach (var clienteModel in _produtoController.ListarPeloNomeSomenteIdENome(nome))
                produtosBinding.Add(clienteModel);
        }

        public bool TrocarStatusDoProduto(int id) =>
            _produtoController.Remover(id);

        public void AlterarProduto(int id)
        {
            var produtoModelSelecionado = _produtoController.Selecionar(id);

            produtoModelSelecionado.Lucro *= 100;

            var pageManager = new GerenciadorDePaginas<ProdutoModel>(
                _dock,
                _produtoController,
                produtoModelSelecionado);

            pageManager.Adicionar(ConfigNinject.ObterInstancia<ProdutoControllerPage>());
            pageManager.DefinirTipoCrud(ControllerEnum.Atualizar);
            pageManager.DefinirMensagemConfirmacao("Deseja atualizar o produto?");
            pageManager.Mostrar();
        }

        public void AbrirFormDeDetalhes(int id)
        {
            var produtoModelSelecionado = _produtoController.Selecionar(id);
                //new FrmDetalhesCliente(produtoModelSelecionado).Show();

            /*var frmDetalhesCliente = new FrmDetalhesCliente(produtoModelSelecionado)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            _dock.Controls.Add(frmDetalhesCliente);
            _dock.Tag = frmDetalhesCliente;

            frmDetalhesCliente.BringToFront();
            frmDetalhesCliente.Show();*/
        }
    }
}
