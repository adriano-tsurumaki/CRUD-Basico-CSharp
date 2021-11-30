using CRUD___Adriano.Features.Dashboards.Controller;
using CRUD___Adriano.Features.Dashboards.Enum;
using CRUD___Adriano.Features.Utils;
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
            PreencherDadosDeVendas();
        }

        private void PreencherCampos()
        {
            lblQuantidadeClientes.Text = _controller.RetornarQuantidadeTotalClientes();
            lblQuantidadeFuncionarios.Text = _controller.RetornarQuantidadeTotalFuncionarios();
        }

        private void PreencherDadosDeVendas()
        {
            cbPeriodoVenda.AtribuirPeloEnum<PeriodoVenda>();
            cbPeriodoVenda.SelectedIndex = 1;

            if(cbPeriodoVenda.EstaSelecionado())
                lblVendasRealizadas.Text = _controller.SelecionarQuantidadeDeVendasEfetuadasPorPeriodo(cbPeriodoVenda.PegarEnumPorDescricao<PeriodoVenda>()).ToString();
        }

        private void CbPeriodoVenda_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPeriodoVenda.EstaSelecionado())
                lblVendasRealizadas.Text = _controller.SelecionarQuantidadeDeVendasEfetuadasPorPeriodo(cbPeriodoVenda.PegarEnumPorDescricao<PeriodoVenda>()).ToString();
        }
    }
}
