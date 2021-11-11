using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Fornecedor.Model;
using CRUD___Adriano.Features.Interface;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Produto.Model;
using CRUD___Adriano.Features.Usuario.Controller;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Produto.View
{
    public partial class FrmCadastroProduto : Form, IViewPage<ProdutoModel>
    {
        private readonly IControllerPage<ProdutoModel> _controller;

        public FrmCadastroProduto(IControllerPage<ProdutoModel> controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        public void BindModel(ref ProdutoModel entidade)
        {

        }

        public bool ValidarComponentes()
        {
            return true;
        }

        private void BtnProcurarFornecedor_Click(object sender, System.EventArgs e)
        {
            txtFornecedor.Texto = ConfigNinject.ObterInstancia<BuscarUsuarioController<FornecedorModel>>().RetornarUsuarioSelecionado()?.Nome;
        }
    }
}
