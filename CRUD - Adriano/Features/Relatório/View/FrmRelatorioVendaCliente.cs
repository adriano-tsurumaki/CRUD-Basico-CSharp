using CRUD___Adriano.Features.Relatório.Controller;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Relatório.View
{
    public partial class FrmRelatorioVendaCliente : Form
    {
        private readonly RelatorioVendaClienteController _controller;

        public FrmRelatorioVendaCliente(RelatorioVendaClienteController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void BtnAbrirFiltro_Click(object sender, System.EventArgs e) =>
            pnlRight.Visible = !pnlRight.Visible;
    }
}
