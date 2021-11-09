using CRUD___Adriano.Features.Dashboards.View;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Dashboards.Controller
{
    public class DashboardController
    {
        private readonly Form _frmDashboard;
        public DashboardController()
        {
            _frmDashboard = new FrmDashboard();
        }

        public Form RetornarFormulario() => _frmDashboard;
    }
}
