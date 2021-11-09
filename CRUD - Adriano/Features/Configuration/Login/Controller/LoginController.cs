using CRUD___Adriano.Features.Configuration.Login.View;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Configuration.Login.Controller
{
    public class LoginController
    {
        private readonly Form _frmLogin;
        public LoginController()
        {
            _frmLogin = new FrmLogin(this);
        }

        public Form RetornarFormulario() => _frmLogin;
    }
}
