using CRUD___Adriano.Features.Relatório.Dao;
using CRUD___Adriano.Features.Relatório.Enum;
using CRUD___Adriano.Features.Relatório.Model;
using CRUD___Adriano.Features.Relatório.View;
using CRUD___Adriano.Features.Vendas.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void AdicionarIdClienteNoFiltro(int idUsuario) =>
            _filtro.ListaIdClientes.Add(idUsuario);

        public void RemoverIdClienteNoFiltro(int idUsuario) =>
            _filtro.ListaIdClientes.Remove(idUsuario);

        public bool PossuiClientesSelecionadosNoFiltro() =>
            _filtro.ListaIdClientes.Count > 0;

        public bool PossuiClienteNaListaDoFiltro(int idUsuario) =>
            _filtro.ListaIdClientes.Any(x => x == idUsuario);

        public void DefinirDataInicioNoFiltro(DateTime dataInicio) =>
            _filtro.DataInicio = dataInicio;

        public void DefinirDataFinalNoFiltro(DateTime dataFinal) =>
            _filtro.DataFinal = dataFinal;

        public void DefinirLimiteClienteNoFiltro(int limite) =>
            _filtro.LimiteQuantidadeCliente = limite;

        public void DefinirTipoComparadorNoFiltro(ComparadorEnum tipoComparador) =>
            _filtro.TipoComparador = tipoComparador;

        public void DefinirValorNoFiltro(double valor) =>
            _filtro.PrecoSelecionado = valor;

        public void DefinirTipoOrdernacaoNoFiltro(OrdernarClienteVendaEnum tipoOrdenacao) =>
            _filtro.TipoOrdernar = tipoOrdenacao;

        public void DefinirOrdernarCrescente(bool ordernarCrescente) =>
            _filtro.OrdernarCrescente = ordernarCrescente;

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
