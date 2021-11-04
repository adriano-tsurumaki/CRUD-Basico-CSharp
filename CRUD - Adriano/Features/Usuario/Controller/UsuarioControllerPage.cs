using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Interface;
using CRUD___Adriano.Features.Usuario.Model;

namespace CRUD___Adriano.Features.Usuario.Controller
{
    public class UsuarioControllerPage<T> : IControllerPage<T>
    {
        private T _usuarioModel;

        private readonly IViewPage<T> _frmUsuarioCadastro;

        public UsuarioControllerPage(IViewPage<T> frmUsuarioCadastro)
        {
            _frmUsuarioCadastro = frmUsuarioCadastro;
        }

        public void AdicionarModel(ref T usuarioModel)
        {
            _usuarioModel = usuarioModel;
            _frmUsuarioCadastro.BindModel(ref _usuarioModel);
        }

        public IViewPage<T> RetornarFormulario() => _frmUsuarioCadastro;

        public bool ValidarForm() =>
            _frmUsuarioCadastro.ValidarComponentes();
    }
}
