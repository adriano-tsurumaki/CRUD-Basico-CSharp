using CRUD___Adriano.Features.Relatório.Dao;
using CRUD___Adriano.Features.Relatório.Model;
using CRUD___Adriano.Features.Relatório.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Relatório.Controller
{
    public class RelatorioVendaClienteController
    {
        private FiltroRelatorioVendaCliente _filtro;
        private readonly RelatorioVendaClienteDao _relatorioVendaClienteDao;
        private readonly FrmRelatorioVendaCliente _frmRelatorioClienteProduto;

        public RelatorioVendaClienteController(RelatorioVendaClienteDao relatorioVendaProdutoDao)
        {
            _filtro = new FiltroRelatorioVendaCliente();
            _relatorioVendaClienteDao = relatorioVendaProdutoDao;
            _frmRelatorioClienteProduto = new FrmRelatorioVendaCliente(this);
        }

        public FrmRelatorioVendaCliente RetornarFormulario() => _frmRelatorioClienteProduto;

        public IList<RelatorioVendaClienteModel> ListarTodosProdutosPeloFiltro()
        {
            try
            {
                return _relatorioVendaClienteDao.ListarVendaClientesPeloFiltro(_filtro);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao tentar listar os produtos");
            }

            return new List<RelatorioVendaClienteModel>();
        }
    }
}
