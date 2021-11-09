using CRUD___Adriano.Features.Configuration.Login.Controller;
using CRUD___Adriano.Features.Configuration.Login.Model;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Configuration.Login.View
{
    public partial class FrmLogin : Form
    {
        private readonly LoginController _controller;
        private UsuarioSistemaModel usuarioSistemaModel;

        public FrmLogin(LoginController controller)
        {
            InitializeComponent();
            _controller = controller;
            usuarioSistemaModel = new UsuarioSistemaModel();
            BindModel();
        }

        private void BindModel()
        {
            txtUsuario.DataBindings.Add("Texto", usuarioSistemaModel, "Nome");
            txtSenha.DataBindings.Add("Texto", usuarioSistemaModel, "Senha");
            cbManterLogado.DataBindings.Add("Checked", usuarioSistemaModel, "ManterLogado");
        }

        private void BtnEntrar_Click(object sender, EventArgs e) =>
            _controller.ValidarLogin(usuarioSistemaModel);
    }
}
