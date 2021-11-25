using CRUD___Adriano.Features.Vendas.Model;
using System.Linq;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.View
{
    public partial class FrmDetalhesVenda : Form
    {
        public FrmDetalhesVenda(VendaModel vendaModel)
        {
            InitializeComponent();
            AtribuirModelParaCampo(vendaModel);
        }

        private void AtribuirModelParaCampo(VendaModel vendaModel)
        {
            lblNumeroVenda.Text = vendaModel.Id.ToString();
            lblNomeVendedor.Text = vendaModel.Colaborador.Nome;
            lblNomeCliente.Text = vendaModel.Cliente.Nome;
            lblLucroTotal.Text = vendaModel.ListaDeProdutos.Sum(x => x.Lucro).ToString("c");
            lblDataEmissao.Text = vendaModel.DataEmissao.ToString("dd/MM/yyyy");
            lblDescontoTotal.Text = vendaModel.DescontoTotal.Formatado;
            lblValorBrutoTotal.Text = vendaModel.ValorBrutoTotal.Formatado;
            lblValorPago.Text = vendaModel.ValorPago.Formatado;

            gridViewProdutos.DataSource = vendaModel.ListaDeProdutos;
            gridViewPagamentos.DataSource = vendaModel.ListaPagamentos;
        }

        private void FrmDetalhesVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape) return;

            Close();
        }

        private void BtnFechar_Click(object sender, System.EventArgs e) =>
            Close();
    }
}
