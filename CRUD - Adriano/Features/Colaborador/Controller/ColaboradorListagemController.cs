using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.Colaborador.View;
using CRUD___Adriano.Features.Controller.PageManager;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Usuario.Controller;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Colaborador.Controller
{
    public class ColaboradorListagemController
    {
        private readonly Panel _dock;
        private ColaboradorController _colaboradorController;
        private FrmListagemColaborador _frmListagemColaborador;

        public ColaboradorListagemController(ColaboradorController colaboradorController, Panel dock)
        {
            _dock = dock;
            ConfiguracaoInicial(colaboradorController);
        }

        public void ConfiguracaoInicial(ColaboradorController colaboradorController)
        {
            _colaboradorController = colaboradorController;
            _frmListagemColaborador = new FrmListagemColaborador(this);
            _frmListagemColaborador.BindGrid(new List<ColaboradorModel>());
        }

        public bool ExcluirColaborador(int id) =>
            _colaboradorController.Remover(id);

        public Form RetornarFormulario() => _frmListagemColaborador;

        public void AlterarColaborador(int id)
        {
            var colaboradorModelSelecionado = _colaboradorController.Selecionar(id);

            var pageManager = new GerenciadorDePaginas<ColaboradorModel>(
                _dock,
                _colaboradorController,
                colaboradorModelSelecionado);

            pageManager.Adicionar(ConfigNinject.ObterInstancia<UsuarioControllerPage<ColaboradorModel>>());
            pageManager.Adicionar(ConfigNinject.ObterInstancia<EmailTelefoneControllerPage<ColaboradorModel>>());
            pageManager.Adicionar(ConfigNinject.ObterInstancia<ColaboradorControllerPage>());
            pageManager.DefinirTipoCrud(Factory.ControllerEnum.Atualizar);
            pageManager.DefinirMensagemConfirmacao("Deseja alterar o funcionário?");
            pageManager.Mostrar();
        }

        public void AbrirFormDeDetalhes(int id)
        {
            var colaboradorModelSelecionado = _colaboradorController.Selecionar(id);

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

        public void ListarTodosOsColaboradores(BindingList<ColaboradorModel> colaboradoresBinding)
        {
            colaboradoresBinding.Clear();
            foreach (var colaboradorModel in _colaboradorController.ListarSomenteIdENome())
                colaboradoresBinding.Add(colaboradorModel);
        }

        public void ListarQuantidadeDeColaboradores(BindingList<ColaboradorModel> colaboradoresBinding, int quantidade)
        {
            colaboradoresBinding.Clear();
            foreach (var colaboradorModel in _colaboradorController.ListarPelaQuantidadeSomenteIdENome(quantidade))
                colaboradoresBinding.Add(colaboradorModel);
        }

        public void SelecionarPeloId(BindingList<ColaboradorModel> colaboradoresBinding, int id)
        {
            colaboradoresBinding.Clear();
            var colaboradorModel = _colaboradorController.SelecionarPeloIdSomenteIdENome(id);
            if (colaboradorModel == null) return;

            colaboradoresBinding.Add(colaboradorModel);
        }

        public void ListarPeloNomeSomenteIdENome(BindingList<ColaboradorModel> colaboradoresBinding, string nome)
        {
            colaboradoresBinding.Clear();
            foreach (var colaboradorModel in _colaboradorController.ListarPeloNomeSomenteIdENome(nome))
                colaboradoresBinding.Add(colaboradorModel);
        }
    }
}
