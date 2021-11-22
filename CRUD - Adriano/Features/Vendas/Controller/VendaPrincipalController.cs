using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Usuario.Model;
using CRUD___Adriano.Features.ValueObject.Porcentagens;
using CRUD___Adriano.Features.Vendas.Dao;
using CRUD___Adriano.Features.Vendas.Enum;
using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class VendaPrincipalController
    {
        private readonly VendaDao _vendaDao;
        
        private readonly FrmVendaPrincipal _frmVendaPrincipal;
        private VendaHeaderController _controllerVendaHeader;
        private PesquisarProdutoController _controllerPesquisarProduto;
        private CarrinhoVendaController _controllerCarrinhoVenda;
        private DescontoVendaController _controllerDescontoVenda;
        private VendaFooterController _controllerVendaFooter;
        private FormaPagamentoController _controllerFormaPagamento;
        private ListaPagamentoController _controllerListaPagamento;

        private readonly VendaModel _vendaModel;

        public VendaPrincipalController(VendaDao vendaDao)
        {
            _vendaDao = vendaDao;

            _frmVendaPrincipal = new FrmVendaPrincipal(this);
            _vendaModel = new VendaModel();

            InstanciarControllers();

            AdicionarControl(_frmVendaPrincipal.pnlHeader, _controllerVendaHeader.RetornarUserControl());
            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerPesquisarProduto.RetornarUserControl());
            AdicionarControl(_frmVendaPrincipal.pnlRightCentral, _controllerCarrinhoVenda.RetornarUserControl());
            AdicionarControl(_frmVendaPrincipal.pnlFooter, _controllerVendaFooter.RetornarUserControl());

            DefinirEventosDosUserControls();

            _frmVendaPrincipal.ShowDialog();
        }

        private void InstanciarControllers()
        {
            _controllerPesquisarProduto = ConfigNinject.ObterInstancia<PesquisarProdutoController>();
            
            _controllerCarrinhoVenda = ConfigNinject.ObterInstancia<CarrinhoVendaController>();
            _controllerCarrinhoVenda.AdicionarModel(_vendaModel.ListaDeProdutos);

            _controllerVendaHeader = ConfigNinject.ObterInstancia<VendaHeaderController>();
            _controllerDescontoVenda = ConfigNinject.ObterInstancia<DescontoVendaController>();
            _controllerVendaFooter = ConfigNinject.ObterInstancia<VendaFooterController>();
            
            _controllerFormaPagamento = ConfigNinject.ObterInstancia<FormaPagamentoController>();
            _controllerFormaPagamento.AdicionarModel(_vendaModel);

            _controllerListaPagamento = ConfigNinject.ObterInstancia<ListaPagamentoController>();
            _controllerListaPagamento.AdicionarModel(_vendaModel.ListaPagamentos);
        }

        private void DefinirEventosDosUserControls()
        {
            _controllerVendaHeader.RetornarUserControl().EventDefinirIdCliente += EventDefinirCliente;
            _controllerVendaHeader.RetornarUserControl().EventDefinirIdColaborador += EventDefinirColaborador;

            _controllerPesquisarProduto.RetornarUserControl().EventEnviarProduto += EventEnviarProduto;
            _controllerCarrinhoVenda.RetornarUserControl().EventHabilitarUcDesconto += EventHabilitarUcDesconto;
            _controllerDescontoVenda.RetornarUserControl().EventDesabilitar += EventDesabilitarUcDesconto;

            _controllerDescontoVenda.RetornarUserControl().EventPegarDesconto += EventPegarDesconto;
            _controllerVendaFooter.EventCancelar += EventCancelar;
            _controllerVendaFooter.EventVoltar += EventVoltar;
            _controllerVendaFooter.EventAvancar += EventAvancar;
            _controllerVendaFooter.EventConfirmar += EventConfirmar;

            _controllerFormaPagamento.RetornarUserControl().EventAdicionarPagamento += EventAdicionarPagamento;
        }

        private void EventDefinirCliente(UsuarioModel clienteModelSelecionado) =>
            _vendaModel.DefinirCliente(clienteModelSelecionado.IdUsuario);

        private void EventDefinirColaborador(UsuarioModel colaboradorModelSelecionado) =>
            _vendaModel.DefinirColaborador(colaboradorModelSelecionado.IdUsuario);

        private void EventEnviarProduto(VendaProdutoModel vendaProdutoSelecionado)
        {
            if (_controllerDescontoVenda.FoiAplicadoDescontoGeral() && MessageBox.Show("Já foi aplicado um desconto geral no pedido, deseja cancelar este desconto?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                AplicarDescontoGeral(0);
            
            _controllerCarrinhoVenda.AdicionarProdutoNoCarrinho(vendaProdutoSelecionado);
        }

        private void EventHabilitarUcDesconto() =>
            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerDescontoVenda.RetornarUserControl());

        private void EventDesabilitarUcDesconto() =>
            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerPesquisarProduto.RetornarUserControl());

        private void EventPegarDesconto(TipoDescontoEnum tipoDesconto, Porcentagem porcentagem)
        {
            if (tipoDesconto == TipoDescontoEnum.Geral)
                AplicarDescontoGeral(porcentagem);
            else
                AplicarDescontoUnitario(porcentagem);
            _controllerCarrinhoVenda.AtualizarCarrinho();
        }

        private void AplicarDescontoGeral(Porcentagem porcentagem)
        {
            foreach (var item in _controllerCarrinhoVenda.RetornarListasDeProdutosParaDesconto())
                item.Desconto = item.PrecoVenda * porcentagem;
        }

        private void AplicarDescontoUnitario(Porcentagem porcentagem)
        {
            var produtoSelecionado = _controllerCarrinhoVenda.RetornarVendaProdutoSelecionadoParaDesconto();
            produtoSelecionado.Desconto = produtoSelecionado.PrecoVenda * porcentagem;
        }

        private void EventAdicionarPagamento(IList<FormaPagamentoModel> listaFormaPagamentos)
        {
            var valorPago = listaFormaPagamentos.Sum(x => x.ValorAPagar.Valor) + _vendaModel.ValorPago;

            if (valorPago > _vendaModel.ValorLiquidoTotal)
            {
                MessageBox.Show("Valor inserido é maior que o valor restante a ser pago!");
                return;
            }

            _controllerListaPagamento.AdicionarPagamentosNaLista(listaFormaPagamentos);
            _controllerFormaPagamento.AtualizarValoresTotais(_vendaModel);
        }

        private void EventCancelar() =>
            CancelarVenda();

        private void EventVoltar()
        {
            _controllerVendaFooter.AtualizarRodape(1);

            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerPesquisarProduto.RetornarUserControl());
            AdicionarControl(_frmVendaPrincipal.pnlRightCentral, _controllerCarrinhoVenda.RetornarUserControl());
        }

        private void EventAvancar()
        {
            if (!PossuiItensNoCarrinho())
            {
                MessageBox.Show("Não é possível prosseguir quando não possui itens no carrinho!");
                return;
            }

            _controllerVendaFooter.AtualizarRodape(2);
            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerFormaPagamento.RetornarUserControl());
            AdicionarControl(_frmVendaPrincipal.pnlRightCentral, _controllerListaPagamento.RetornarUserControl());
            _controllerFormaPagamento.AtualizarValoresTotais(_vendaModel);
        }

        private bool PossuiItensNoCarrinho() =>
            _controllerCarrinhoVenda.PossuiItensNoCarrinho();

        private void EventConfirmar()
        {
            if (!ValidarModel()) return;

            if (MessageBox.Show("Deseja efetuar a venda?", "Confirmação", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                _vendaDao.EfetuarVenda(_vendaModel);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao efetuar a venda!");
            }
        }

        private bool ValidarModel()
        {
            if (_vendaModel.IdCliente == 0)
            {
                MessageBox.Show("Selecione um cliente!", "Aviso");
                return false;
            }
            if (_vendaModel.IdColaborador == 0)
            {
                MessageBox.Show("Selecione um funcionário!", "Aviso");
                return false;
            }
            if (_vendaModel.ListaPagamentos.Count == 0 || _vendaModel.ValorPago != _vendaModel.ValorLiquidoTotal)
            {
                MessageBox.Show("Efetue o pagamento total!", "Aviso");
                return false;
            }

            return true;
        }

        public void AdicionarControl(Panel panel, UserControl formFilha)
        {
            panel.Controls.Add(formFilha);
            panel.Tag = formFilha;

            formFilha.Dock = DockStyle.Fill;
            formFilha.BringToFront();
            formFilha.Show();
        }

        public void AdicionarControl(Panel panel, Form formFilha)
        {
            panel.Controls.Clear();

            formFilha.TopLevel = false;
            formFilha.FormBorderStyle = FormBorderStyle.None;
            formFilha.Dock = DockStyle.Fill;

            panel.Controls.Add(formFilha);
            panel.Tag = formFilha;

            formFilha.BringToFront();
            formFilha.Show();
            formFilha.Focus();
        }

        public void GerenciarKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    CancelarVenda();
                    break;
            }
        }

        private void CancelarVenda()
        {
            if (MessageBox.Show("Deseja cancelar a venda?", "Confirmação", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            _frmVendaPrincipal.Close();
        }
    }
}
