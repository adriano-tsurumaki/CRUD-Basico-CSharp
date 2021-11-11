using CRUD___Adriano.Features.Factory;

namespace CRUD___Adriano.Features.Usuario.Controller
{
    public class BuscarUsuarioController<T> where T : class
    {
        private IControllerListarIdNome<T> _controller;

        public BuscarUsuarioController(IControllerListarIdNome<T> controller)
        {
            _controller = controller;
        }


    }
}
