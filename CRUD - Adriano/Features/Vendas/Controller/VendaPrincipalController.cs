using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.ValueObject.Porcentagens;
using CRUD___Adriano.Features.Vendas.Enum;
using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System.Linq;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class VendaPrincipalController
    {
        private FrmVendaPrincipal _frmVendaPrincipal;
        private PesquisarProdutoController _controllerPesquisarProduto;
        private CarrinhoVendaController _controllerCarrinhoVenda;
        private VendaHeaderController _controllerVendaHeader;
        private DescontoVendaController _controllerDescontoVenda;

        private ClienteModel _clienteModelSelecionado;

        public VendaPrincipalController()
        {
            _frmVendaPrincipal = new FrmVendaPrincipal(this);

            InstanciarControllers();

            AdicionarControl(_frmVendaPrincipal.pnlHeader, _controllerVendaHeader.RetornarUserControl());
            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerPesquisarProduto.RetornarUserControl());
            AdicionarControl(_frmVendaPrincipal.pnlRightCentral, _controllerCarrinhoVenda.RetornarUserControl());

            DefinirEventosDosUserControls();

            _frmVendaPrincipal.ShowDialog();
        }

        private void InstanciarControllers()
        {
            _controllerPesquisarProduto = ConfigNinject.ObterInstancia<PesquisarProdutoController>();
            _controllerCarrinhoVenda = ConfigNinject.ObterInstancia<CarrinhoVendaController>();
            _controllerVendaHeader = ConfigNinject.ObterInstancia<VendaHeaderController>();
            _controllerDescontoVenda = ConfigNinject.ObterInstancia<DescontoVendaController>();
        }

        private void DefinirEventosDosUserControls()
        {
            _controllerVendaHeader.RetornarUserControl().EventDefinirCliente += EventDefinirCliente;
            _controllerPesquisarProduto.RetornarUserControl().EventEnviarProduto += EventEnviarProduto;
            _controllerCarrinhoVenda.RetornarUserControl().EventHabilitarUcDesconto += EventHabilitarUcDesconto;
            _controllerDescontoVenda.RetornarUserControl().EventDesabilitar += EventDesabilitarUcDesconto;

            _controllerDescontoVenda.RetornarUserControl().EventPegarDesconto += EventPegarDesconto;
        }

        private void EventDefinirCliente(ClienteModel clienteModelSelecionado) =>
            _clienteModelSelecionado = clienteModelSelecionado;

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
