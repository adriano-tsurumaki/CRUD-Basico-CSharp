using CRUD___Adriano.Features.Configuration.Login.Dao;
using CRUD___Adriano.Features.Configuration.Login.Model;
using CRUD___Adriano.Features.Configuration.Login.View;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Configuration.Login.Controller
{
    public class LoginController
    {
        private readonly Form _frmLogin;
        private readonly LoginDao _loginDao;

        public LoginController(Dao.LoginDao loginDao)
        {
            _frmLogin = new FrmLogin(this);
            _loginDao = loginDao;
        }

        public Form RetornarFormulario() => _frmLogin;

        public void ValidarLogin(UsuarioSistemaModel loginModel)
        {
            try
            {
                if (_loginDao.ValidarLogin(loginModel))
                {
                    _frmLogin.DialogResult = DialogResult.OK;
                    _frmLogin.Close();
                }
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Houve um erro ao validar o login");
            }
        }
    }
}
