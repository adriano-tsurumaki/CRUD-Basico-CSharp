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

        public LoginController(LoginDao loginDao)
        {
            _loginDao = loginDao;
            _frmLogin = new FrmLogin(this);
        }

        public Form RetornarFormulario() => _frmLogin;

        public void VerificarSeExisteUsuarioJaConectado()
        {
            try
            {
                if (!_loginDao.VerificarSeExisteUsuarioJaConectado()) return;

                _frmLogin.DialogResult = DialogResult.OK;
                _frmLogin.Close();
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Houve um erro ao verificar se existe usuário já conectado!");
            }
        }

        public void ValidarLogin(UsuarioSistemaModel loginModel)
        {
            try
            {
                if (_loginDao.ValidarLogin(loginModel))
                {
                    _frmLogin.DialogResult = DialogResult.OK;
                    _frmLogin.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreto!");
                }
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Houve um erro ao validar o login!");
            }
        }
    }
}
