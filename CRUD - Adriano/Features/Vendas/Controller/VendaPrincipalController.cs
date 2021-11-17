using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public delegate void HabilitarUserControlHandler();

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
            _controllerDescontoVenda.RetornarUserControl().EventDesabilitarUcDesconto += EventDesabilitarUcDesconto;
        }

        private void EventDefinirCliente(ClienteModel clienteModelSelecionado) =>
            _clienteModelSelecionado = clienteModelSelecionado;

        private void EventEnviarProduto(VendaProdutoModel vendaProdutoSelecionado) =>
            _controllerCarrinhoVenda.AdicionarProdutoNoCarrinho(vendaProdutoSelecionado);

        private void EventHabilitarUcDesconto() =>
            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerDescontoVenda.RetornarUserControl());

        private void EventDesabilitarUcDesconto() =>
            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerPesquisarProduto.RetornarUserControl());

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
