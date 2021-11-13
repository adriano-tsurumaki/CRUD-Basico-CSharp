using System.Drawing;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class FrmVendaPrincipal : Form
    {
        public FrmVendaPrincipal()
        {
            InitializeComponent();
        }

        private void FrmVendaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void FrmVendaPrincipal_Load(object sender, System.EventArgs e)
        {
            pnlLeftCentral.Size = new Size((Width / 2) - 12, pnlLeftCentral.Size.Height);
        }
    }
}
