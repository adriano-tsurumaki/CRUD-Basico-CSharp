using CRUD___Adriano.Features.Relatório.Dao;
using CRUD___Adriano.Features.Relatório.Model;
using CRUD___Adriano.Features.Relatório.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Relatório.Controller
{
    public class RelatorioVendaProdutoController
    {
        private FiltroRelatorioVendaProduto _filtro;
        private readonly RelatorioVendaProdutoDao _relatorioVendaProdutoDao;
        private readonly FrmRelatorioVendaProduto _frmRelatorioVendaProduto;

        public RelatorioVendaProdutoController(RelatorioVendaProdutoDao relatorioVendaProdutoDao)
        {
            _filtro = new FiltroRelatorioVendaProduto();
            _relatorioVendaProdutoDao = relatorioVendaProdutoDao;
            _frmRelatorioVendaProduto = new FrmRelatorioVendaProduto(this);
        }

        public IList<RelatorioVendaProdutoModel> ListarTodosProdutosPeloFiltro()
        {
            try
            {
                return _relatorioVendaProdutoDao.ListarProdutosPeloFiltro(_filtro);
            }   
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao tentar listar os produtos");
            }

            return new List<RelatorioVendaProdutoModel>();
        }

        public void DefinirIdClienteNoFiltro(int idUsuario) =>
            _filtro.IdCliente = idUsuario;

        public void DefinirIdProdutoNoFiltro(int idProduto) =>
            _filtro.IdProduto = idProduto;

        public void DefinirDataInicioNoFiltro(DateTime dataInicio) =>
            _filtro.DataInicio = dataInicio;

        public void DefinirDataFinalNoFiltro(DateTime dataFinal) =>
            _filtro.DataFinal = dataFinal;

        public FrmRelatorioVendaProduto RetornarFormulario() => _frmRelatorioVendaProduto;
    }
}
