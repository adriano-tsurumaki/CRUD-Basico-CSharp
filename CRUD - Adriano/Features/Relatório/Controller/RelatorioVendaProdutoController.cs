using CRUD___Adriano.Features.Relatório.Dao;
using CRUD___Adriano.Features.Relatório.Model;
using CRUD___Adriano.Features.Relatório.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Relatório.Controller
{
    public class RelatorioVendaProdutoController
    {
        private FiltroRelatorioVendaProduto _filtro;
        private readonly RelatorioVendaProdutoDao _relatorioVendaProdutoDao;
        private readonly FrmRelatorioVendaProduto _frmRelatorioVendaProduto;
        private readonly BindingList<RelatorioVendaProdutoModel> _bindingRelatorioVendaProduto;

        public RelatorioVendaProdutoController(RelatorioVendaProdutoDao relatorioVendaProdutoDao)
        {
            _filtro = new FiltroRelatorioVendaProduto();
            _relatorioVendaProdutoDao = relatorioVendaProdutoDao;
            _bindingRelatorioVendaProduto = new BindingList<RelatorioVendaProdutoModel>();
            _frmRelatorioVendaProduto = new FrmRelatorioVendaProduto(this);
        }

        public void AtualizarLista()
        {
            try
            {
                _bindingRelatorioVendaProduto.Clear();

                foreach (var item in _relatorioVendaProdutoDao.ListarProdutosPeloFiltro(_filtro))
                    _bindingRelatorioVendaProduto.Add(item);
            }   
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao tentar listar os produtos");
            }
        }

        public BindingList<RelatorioVendaProdutoModel> RetornarBindingRelatorioVendaProduto() => _bindingRelatorioVendaProduto;

        public void DefinirIdClienteNoFiltro(int idUsuario) =>
            _filtro.IdCliente = idUsuario;

        public void DefinirIdProdutoNoFiltro(int idProduto) =>
            _filtro.IdProduto = idProduto;

        public void DefinirDataInicioNoFiltro(DateTime dataInicio) =>
            _filtro.DataInicio = dataInicio;

        public void DefinirDataFinalNoFiltro(DateTime dataFinal) =>
            _filtro.DataFinal = dataFinal;

        public FrmRelatorioVendaProduto RetornarFormulario() => _frmRelatorioVendaProduto;

        public string RetornarQuantidadeTotalDaLista() =>
            _bindingRelatorioVendaProduto.ToList().Sum(x => x.Quantidade).ToString();

        public string RetornarTotalBrutoDaLista() =>
            _bindingRelatorioVendaProduto.ToList().Sum(x => x.PrecoBrutoTotal.Valor).ToString("c");

        public string RetornarDescontoTotalDaLista() =>
            _bindingRelatorioVendaProduto.ToList().Sum(x => x.DescontoTotal.Valor).ToString("c");

        public string RetornarTotalLiquidoDaLista() =>
            _bindingRelatorioVendaProduto.ToList().Sum(x => x.PrecoLiquidoTotal.Valor).ToString("c");

        public string RetornarTotalLucroDaLista() =>
            _bindingRelatorioVendaProduto.ToList().Sum(x => x.LucroTotal.Valor).ToString("c");
    }
}
