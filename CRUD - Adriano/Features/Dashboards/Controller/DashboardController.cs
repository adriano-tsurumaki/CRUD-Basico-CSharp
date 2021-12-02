using CRUD___Adriano.Features.Cliente.Dao;
using CRUD___Adriano.Features.Colaborador.Dao;
using CRUD___Adriano.Features.Dashboards.Enum;
using CRUD___Adriano.Features.Dashboards.View;
using CRUD___Adriano.Features.Vendas.Dao;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Dashboards.Controller
{
    public class DashboardController
    {
        private readonly Form _frmDashboard;
        private readonly ClienteDao _clienteDao;
        private readonly ColaboradorDao _colaboradorDao;
        private readonly VendaDao _vendaDao;

        public DashboardController(ClienteDao clienteDao, ColaboradorDao colaboradorDao, VendaDao vendaDao)
        {
            _clienteDao = clienteDao;
            _colaboradorDao = colaboradorDao;
            _vendaDao = vendaDao;
            _frmDashboard = new FrmDashboard(this);
        }

        public Form RetornarFormulario() => _frmDashboard;

        public string RetornarQuantidadeTotalClientes()
        {
            try
            {
                return _clienteDao.SelecionarQuantidadeDeTodosOsClientes().ToString();
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Houve um erro ao consultar a quantidade total de clientes");
            }
            return "0";
        }

        public int SelecionarQuantidadeDeVendasEfetuadasPorPeriodo(PeriodoVenda periodoVenda)
        {
            try
            {
                return _vendaDao.SelecionarQuantidadeDeVendasEfetuadasPorPeriodo(periodoVenda);
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Houve um erro ao consultar a quantidade de vendas efetuadas");
            }

            return 0;
        }

        public string RetornarQuantidadeTotalFuncionarios()
        {
            try
            {
                return _colaboradorDao.SelecionarQuantidadeDeTodosOsColaboradores().ToString();
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Houve um erro ao consultar a quantidade total de colaboradores");
            }
            return "0";
        }
    }
}
