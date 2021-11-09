using CRUD___Adriano.Features.Dashboards.Controller;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Dashboards.View
{
    public partial class FrmDashboard : Form
    {
        private readonly DashboardController _controller;

        public FrmDashboard(DashboardController controller)
        {
            InitializeComponent();
            _controller = controller;
            PreencherCampos();
        }

        private void PreencherCampos()
        {
            lblQuantidadeClientes.Text = _controller.RetornarQuantidadeTotalClientes();
            lblQuantidadeFuncionarios.Text = _controller.RetornarQuantidadeTotalFuncionarios();
        }
    }
}
