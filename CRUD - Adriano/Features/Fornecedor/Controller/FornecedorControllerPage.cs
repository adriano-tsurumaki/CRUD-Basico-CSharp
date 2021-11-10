using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Fornecedor.Model;
using CRUD___Adriano.Features.Fornecedor.View;
using CRUD___Adriano.Features.Interface;

namespace CRUD___Adriano.Features.Fornecedor.Controller
{
    public class FornecedorControllerPage : IControllerPage<FornecedorModel>
    {
        private readonly IViewPage<FornecedorModel> _frmFornecedorPage;

        public FornecedorControllerPage() =>
            _frmFornecedorPage = new FrmCadastroFornecedor();

        public IViewPage<FornecedorModel> RetornarFormulario() => _frmFornecedorPage;

        public void AdicionarModel(ref FornecedorModel fornecedorModel) =>
            _frmFornecedorPage.BindModel(ref fornecedorModel);

        public bool ValidarForm() => true;
    }
}
