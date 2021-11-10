using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Fornecedor.Model;
using CRUD___Adriano.Features.Interface;
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

        public void BindModel(ref FornecedorModel fornecedorModel) =>
            txtObservacao.DataBindings.Add("Texto", fornecedorModel, "Observacao");

        public bool ValidarComponentes() => true;
    }
}
