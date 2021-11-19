using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.ValueObject.Porcentagens;
using CRUD___Adriano.Features.Vendas.Enum;
using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class VendaPrincipalController
    {
        private FrmVendaPrincipal _frmVendaPrincipal;
        private VendaHeaderController _controllerVendaHeader;
        private PesquisarProdutoController _controllerPesquisarProduto;
        private CarrinhoVendaController _controllerCarrinhoVenda;
        private DescontoVendaController _controllerDescontoVenda;
        private VendaFooterController _controllerVendaFooter;
        private FormaPagamentoController _controllerFormaPagamento;

        private VendaModel _vendaModel;

        public VendaPrincipalController()
        {
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
        }

        private void DefinirEventosDosUserControls()
        {
            _controllerVendaHeader.RetornarUserControl().EventDefinirCliente += EventDefinirCliente;
            _controllerPesquisarProduto.RetornarUserControl().EventEnviarProduto += EventEnviarProduto;
            _controllerCarrinhoVenda.RetornarUserControl().EventHabilitarUcDesconto += EventHabilitarUcDesconto;
            _controllerDescontoVenda.RetornarUserControl().EventDesabilitar += EventDesabilitarUcDesconto;

            _controllerDescontoVenda.RetornarUserControl().EventPegarDesconto += EventPegarDesconto;
            _controllerVendaFooter.EventAvancar += EventAvancar;
            _controllerVendaFooter.EventVoltar += EventVoltar;

            _controllerFormaPagamento.RetornarUserControl().EventAdicionarPagamento += EventAdicionarPagamento;
        }

        private void EventDefinirCliente(ClienteModel clienteModelSelecionado) =>
            _vendaModel.Cliente = clienteModelSelecionado;

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

        private void EventVoltar()
        {
            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerPesquisarProduto.RetornarUserControl());
            AdicionarControl(_frmVendaPrincipal.pnlRightCentral, _controllerCarrinhoVenda.RetornarUserControl());
        }

        private void EventAvancar()
        {
            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerFormaPagamento.RetornarUserControl());
            _controllerFormaPagamento.AtualizarValoresTotais(_vendaModel);
        }

        private void EventAdicionarPagamento(IList<FormaPagamentoModel> listaFormaPagamentos)
        {
            foreach (var pagamento in listaFormaPagamentos)
                _vendaModel.ListaPagamentos.Add(pagamento);
            _controllerFormaPagamento.AtualizarValoresTotais(_vendaModel);
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
                    _frmVendaPrincipal.Close();
                    break;
            }
        }
    }
}
