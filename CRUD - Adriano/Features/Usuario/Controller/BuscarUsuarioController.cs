using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Usuario.View;
using System.ComponentModel;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Usuario.Controller
{
    public class BuscarUsuarioController<T> where T : class, new()
    {
        private readonly IControllerListarIdNome<T> _controller;
        private readonly FrmBuscarUsuario<T> _frmBuscarUsuario;
        public T usuarioSelecionado;

        public BuscarUsuarioController(IControllerListarIdNome<T> controller)
        {
            _controller = controller;
            _frmBuscarUsuario = new FrmBuscarUsuario<T>(this);
            _frmBuscarUsuario.BindGrid(new BindingList<T>());
        }

        public Form RetornarFormulario() => _frmBuscarUsuario;

        public BuscarUsuarioController<T> DefinirNomePrevio(string nome)
        {
            _frmBuscarUsuario.DefinirNomePrevio(nome);
            return this;
        }

        public BuscarUsuarioController<T> DefinirTituloDoForm(string nome)
        {
            _frmBuscarUsuario.DefinirTituloDoForm(nome);
            return this;
        }

        public void ListarPeloNomeSomenteIdENome(BindingList<T> usuariosBinding, string nome)
        {
            usuariosBinding.Clear();
            foreach(var usuarioModel in _controller.ListarPeloNomeSomenteIdENome(nome))
                usuariosBinding.Add(usuarioModel);
        }

        public void ListarSomenteIdENome(BindingList<T> usuariosBinding)
        {
            usuariosBinding.Clear();
            foreach (var usuarioModel in _controller.ListarSomenteIdENome())
                usuariosBinding.Add(usuarioModel);
        }

        public void ListarPorQuantidade(BindingList<T> usuariosBinding, int quantidade)
        {
            usuariosBinding.Clear();
            foreach (var usuarioModel in _controller.ListarPelaQuantidadeSomenteIdENome(quantidade))
                usuariosBinding.Add(usuarioModel);
        }

        public void SelecionarPeloId(BindingList<T> usuariosBinding, int id)
        {
            usuariosBinding.Clear();
            var usuarioModel = _controller.SelecionarPeloIdSomenteIdENome(id);
            if (usuarioModel == null) return;

            usuariosBinding.Add(usuarioModel);
        }

        public void AtribuirUsuarioSelecionado(T usuario)
        {
            usuarioSelecionado = usuario;
            _frmBuscarUsuario.Close();
        }

        public T RetornarUsuarioSelecionado()
        {
            _frmBuscarUsuario.ShowDialog();

            return usuarioSelecionado ?? new T();
        }
    }
}
