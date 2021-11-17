using CRUD___Adriano.Features.Vendas.Controller;
using System.Drawing;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class FrmVendaPrincipal : Form
    {
        private readonly VendaPrincipalController _controller;

        public FrmVendaPrincipal(VendaPrincipalController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void FrmVendaPrincipal_KeyDown(object sender, KeyEventArgs e) =>
            _controller.GerenciarKeyDown(sender, e);

        private void FrmVendaPrincipal_Load(object sender, System.EventArgs e)
        {
            pnlLeftCentral.Size = new Size((Width / 2) - 12, pnlLeftCentral.Size.Height);
        }
    }
}
