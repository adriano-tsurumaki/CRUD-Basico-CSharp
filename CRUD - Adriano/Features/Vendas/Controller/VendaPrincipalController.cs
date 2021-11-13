using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class VendaPrincipalController
    {
        private readonly FrmVendaPrincipal _frmVendaPrincipal;
        private readonly PesquisarProdutoController _controllerPesquisarProduto;
        private readonly CarrinhoVendaController _controllerCarrinhoVenda;

        public VendaPrincipalController()
        {
            _frmVendaPrincipal = new FrmVendaPrincipal();
            _controllerPesquisarProduto = ConfigNinject.ObterInstancia<PesquisarProdutoController>();
            _controllerCarrinhoVenda = ConfigNinject.ObterInstancia<CarrinhoVendaController>();

            _controllerPesquisarProduto.RetornarUserControl().EventEnviarProduto += EventEnviarProduto;

            AdicionarControl(_frmVendaPrincipal.pnlHeader, new UcVendaHeader());
            AdicionarControl(_frmVendaPrincipal.pnlLeftCentral, _controllerPesquisarProduto.RetornarUserControl());
            AdicionarControl(_frmVendaPrincipal.pnlRightCentral, _controllerCarrinhoVenda.RetornarUserControl());

            _frmVendaPrincipal.ShowDialog();
        }

        public void EventEnviarProduto(VendaProdutoModel vendaProdutoSelecionado) =>
            _controllerCarrinhoVenda.AdicionarProdutoNoCarrinho(vendaProdutoSelecionado);

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
    }
}
