using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Fornecedor.Model;
using CRUD___Adriano.Features.Interface;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Produto.Model;
using CRUD___Adriano.Features.Usuario.Controller;
using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.ValueObject.Precos;
using System.Diagnostics;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Produto.View
{
    public partial class FrmCadastroProduto : Form, IViewPage<ProdutoModel>
    {
        private readonly IControllerPage<ProdutoModel> _controller;
        private ProdutoModel _produtoModel;

        public FrmCadastroProduto(IControllerPage<ProdutoModel> controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        public void BindModel(ref ProdutoModel produtoModel)
        {
            _produtoModel = produtoModel;
            var fornecedor = produtoModel.Fornecedor;
            txtFornecedor.DataBindings.Add("Texto", fornecedor, "Nome");
            txtCodigoBarras.DataBindings.Add("Texto", produtoModel, "CodigoBarras");
            txtNome.DataBindings.Add("Texto", produtoModel, "Nome");
            txtLucro.DataBindings.Add("Texto", produtoModel, "Lucro");
            txtPrecoBruto.Texto = produtoModel.PrecoBruto.Formatado;
            txtQuantidade.DataBindings.Add("Texto", produtoModel, "Quantidade");
        }

        public bool ValidarComponentes()
        {
            if (txtFornecedor.NuloOuVazio() || txtQuantidade.NuloOuVazio() ||
                txtCodigoBarras.NuloOuVazio() || txtNome.NuloOuVazio() ||
                txtPrecoBruto.NuloOuVazio() || txtLucro.NuloOuVazio()) 
                return false;

            _produtoModel.PrecoBruto = txtPrecoBruto.Texto;

            return true;
        }

        private void BtnProcurarFornecedor_Click(object sender, System.EventArgs e) =>
            txtFornecedor.Texto = _produtoModel.Fornecedor.Nome = BuscarNomeDoFornecedor();

        private void TxtFornecedor__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            txtFornecedor.Texto = _produtoModel.Fornecedor.Nome = BuscarNomeDoFornecedor(txtFornecedor.Texto);
        }

        private string BuscarNomeDoFornecedor() =>
            ConfigNinject.ObterInstancia<BuscarUsuarioController<FornecedorModel>>().RetornarUsuarioSelecionado()?.Nome;

        private string BuscarNomeDoFornecedor(string nome) =>
            ConfigNinject.ObterInstancia<BuscarUsuarioController<FornecedorModel>>().DefinirNomePrevio(nome).RetornarUsuarioSelecionado()?.Nome;

        // TODO: Fazer o gerador de código de barra!
        private void BtnGerarCodigoBarra_Click(object sender, System.EventArgs e)
        {

        }
        
        //private bool evitarLoopPrecoBruto;

        private void TxtPrecoBruto__TextChanged(object sender, System.EventArgs e)
        {
            txtPrecoBruto.SelectionLength = 0;
            Preco precoBruto = txtPrecoBruto.Texto;
            txtPrecoBruto.Texto = precoBruto.Formatado;

            //txtPrecoBruto.SelectionStart = txtPrecoBruto.Texto.Length;
            //txtPrecoBruto.SelectionStart++;


            //if (evitarLoopPrecoBruto)
            //{
            //    txtPrecoBruto.SelectionStart = txtPrecoBruto.Texto.Length;
            //    evitarLoopPrecoBruto = false;
            //    return;
            //}

            //var textoFormatado = "R$ " + txtPrecoBruto.Texto.RetornarSomenteTextoEmNumeros();

            //if (textoFormatado.Length > 5)
            //    textoFormatado = textoFormatado.Insert(textoFormatado.Length - 2, ",");

            //if (textoFormatado != txtPrecoBruto.Texto)
            //    evitarLoopPrecoBruto = true;


            //txtPrecoBruto.Texto = textoFormatado;
            Debug.WriteLine(txtPrecoBruto.SelectionStart);
        }

        private void TxtPrecoBruto__KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar)) e.Handled = true;

            
        }
    }
}
