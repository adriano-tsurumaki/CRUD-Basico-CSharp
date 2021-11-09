using CRUD___Adriano.Features.Configuration.Login.Controller;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Configuration.Login.View
{
    public partial class FrmLogin : Form
    {
        private readonly LoginController _controller;

        public FrmLogin(LoginController controller)
        {
            InitializeComponent();
            _controller = controller;
        }
    }
}
