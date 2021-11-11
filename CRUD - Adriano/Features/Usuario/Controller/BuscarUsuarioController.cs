using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Usuario.View;

namespace CRUD___Adriano.Features.Usuario.Controller
{
    public class BuscarUsuarioController<T> where T : class
    {
        private IControllerListarIdNome<T> _controller;
        private readonly FrmBuscarUsuario<T> _frmBuscarUsuario;

        public BuscarUsuarioController(IControllerListarIdNome<T> controller)
        {
            _controller = controller;
            _frmBuscarUsuario = new FrmBuscarUsuario<T>(this);
            _frmBuscarUsuario.BindGrid(_controller.ListarSomenteIdENome());
        }
    }
}
