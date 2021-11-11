using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Fornecedor.Model;
using CRUD___Adriano.Features.Utils;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Fornecedor.View
{
    public partial class FrmCadastroFornecedor : Form, IViewPage<FornecedorModel>
    {
        public FrmCadastroFornecedor()
        {
            InitializeComponent();
        }

        public void BindModel(ref FornecedorModel fornecedorModel)
        {
            txtObservacao.DataBindings.Add("Texto", fornecedorModel, "Observacao");
            txtCnpj.DataBindings.Add("Texto", fornecedorModel, "Cnpj");
        }

        public bool ValidarComponentes()
        {
            if (txtCnpj.NuloOuVazio()) return false;

            return true;
        }

        private void TxtCnpj__TextChanged(object sender, System.EventArgs e)
        {

        }

        private void TxtObservacao__TextChanged(object sender, System.EventArgs e) =>
            lblCaracteresObservacao.Text = $"{500 - txtObservacao.Texto.Length} caracteres restando";
    }
}
