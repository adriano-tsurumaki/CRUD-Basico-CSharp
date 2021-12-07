using CRUD___Adriano.Features.Relatório.Dao;
using CRUD___Adriano.Features.Relatório.Enum;
using CRUD___Adriano.Features.Relatório.Model;
using CRUD___Adriano.Features.Relatório.View;
using CRUD___Adriano.Features.Vendas.Sql;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Relatório.Controller
{
    public class RelatorioVendaClienteController
    {
        private FiltroRelatorioVendaCliente _filtro;
        private readonly RelatorioVendaClienteDao _relatorioVendaClienteDao;
        private readonly FrmRelatorioVendaCliente _frmRelatorioClienteProduto;
        private readonly BindingList<RelatorioVendaClienteModel> _bindingRelatorioVendaCliente;

        public RelatorioVendaClienteController(RelatorioVendaClienteDao relatorioVendaProdutoDao)
        {
            _filtro = new FiltroRelatorioVendaCliente();
            _relatorioVendaClienteDao = relatorioVendaProdutoDao;
            _bindingRelatorioVendaCliente = new BindingList<RelatorioVendaClienteModel>();
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

        public void AtualizarLista()
        {
            try
            {
                _bindingRelatorioVendaCliente.Clear();

                foreach (var relatorio in _relatorioVendaClienteDao.ListarVendaClientesPeloFiltro(_filtro))
                    _bindingRelatorioVendaCliente.Add(relatorio);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao tentar listar os produtos");
            }
        }

        public BindingList<RelatorioVendaClienteModel> RetornarBindingRelatorioVendaCliente() => _bindingRelatorioVendaCliente;

        public string RetornarQuantidadeTotalDaLista() =>
            _bindingRelatorioVendaCliente.ToList().Sum(x => x.QuantidadeVendas).ToString();

        public string RetornarTotalBrutoDaLista() =>
            _bindingRelatorioVendaCliente.ToList().Sum(x => x.TotalBruto.Valor).ToString("c");

        public string RetornarDescontoTotalDaLista() =>
            _bindingRelatorioVendaCliente.ToList().Sum(x => x.DescontoTotal.Valor).ToString("c");

        public string RetornarTotalLiquidoDaLista() =>
            _bindingRelatorioVendaCliente.ToList().Sum(x => x.TotalLiquido.Valor).ToString("c");
    }
}
