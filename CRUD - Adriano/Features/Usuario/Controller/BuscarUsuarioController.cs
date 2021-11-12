using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Usuario.View;

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
        }

        public BuscarUsuarioController<T> DefinirNomePrevio(string nome)
        {
            _frmBuscarUsuario.DefinirNomePrevio(nome);
            ListarPeloNomeSomenteIdENome(nome);
            return this;
        }

        public void ListarPeloNomeSomenteIdENome(string nome) =>
            _frmBuscarUsuario.BindGrid(_controller.ListarPeloNomeSomenteIdENome(nome));

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
