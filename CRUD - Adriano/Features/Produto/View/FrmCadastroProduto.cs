using CRUD___Adriano.Features.Configuration;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Fornecedor.Model;
using CRUD___Adriano.Features.Interface;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Produto.Model;
using CRUD___Adriano.Features.Usuario.Controller;
using CRUD___Adriano.Features.Utils;
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
            txtPrecoBruto.Texto = produtoModel.PrecoBruto.Formatado;
            txtLucro.Texto = produtoModel.Lucro.ToString();
            txtQuantidade.DataBindings.Add("Texto", produtoModel, "Quantidade");
        }

        public bool ValidarComponentes()
        {
            if (_produtoModel.Fornecedor.Id == 0)
            {
                MessageBox.Show("Obrigatório selecionar um fornecedor para o produto!");
                return false;
            }
            else if (txtCodigoBarras.NuloOuVazio())
            {
                MessageBox.Show("O campo codigo de barras não pode ser nula ou vazia!");
                return false;
            }
            else if (txtNome.NuloOuVazio())
            {
                MessageBox.Show("O campo nome não pode ser nula ou vazia!");
                return false;
            }
            else if (txtQuantidade.NuloOuVazio())
            {
                MessageBox.Show("O campo quantidade não pode ser nula ou vazia!");
                return false;
            }
            else if (txtPrecoBruto.NuloOuVazio())
            {
                MessageBox.Show("O campo preco bruto não pode ser nula ou vazia!");
                return false;
            }
            else if (txtLucro.NuloOuVazio())
            {
                MessageBox.Show("O campo lucro não pode ser nula ou vazia!");
                return false;
            }

            _produtoModel.PrecoBruto = txtPrecoBruto.Texto;
            _produtoModel.Lucro = txtLucro.Texto.PorcentoOuZero();
            return true;
        }

        private void BtnProcurarFornecedor_Click(object sender, System.EventArgs e)
        {
            if (txtFornecedor.NuloOuVazio())
                AtribuirFornecedor(BuscarFornecedor());
            else
                AtribuirFornecedor(BuscarFornecedorPeloNome(txtFornecedor.Texto));
        }

        private void TxtFornecedor__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                _produtoModel.Fornecedor.Id = 0;
                return;
            }

            AtribuirFornecedor(BuscarFornecedorPeloNome(txtFornecedor.Texto));
        }

        private void AtribuirFornecedor(FornecedorModel fornecedorModel)
        {
            txtFornecedor.Texto = _produtoModel.Fornecedor.Nome = fornecedorModel.Nome;
            _produtoModel.Fornecedor.Id = fornecedorModel.Id;
        }

        private FornecedorModel BuscarFornecedor() =>
            ConfigNinject.ObterInstancia<BuscarUsuarioController<FornecedorModel>>().RetornarUsuarioSelecionado();

        private FornecedorModel BuscarFornecedorPeloNome(string nome) =>
            ConfigNinject.ObterInstancia<BuscarUsuarioController<FornecedorModel>>().DefinirNomePrevio(nome).RetornarUsuarioSelecionado();

        private void BtnGerarCodigoBarra_Click(object sender, System.EventArgs e)
        {
            _produtoModel.CodigoBarras = RandomEntity.GerarCodigoDeBarrasAleatorio();
            txtCodigoBarras.Texto = _produtoModel.CodigoBarras;
        }

        private bool evitarLoopPrecoBruto;

        private void TxtPrecoBruto__TextChanged(object sender, System.EventArgs e)
        {
            if (evitarLoopPrecoBruto)
            {
                txtPrecoBruto.SelectionStart = txtPrecoBruto.Texto.Length;
                evitarLoopPrecoBruto = false;
                return;
            }

            var textoFormatado = "R$ " + txtPrecoBruto.Texto.RetornarSomenteTextoEmNumeros();

            if (textoFormatado.Length > 5)
                textoFormatado = textoFormatado.Insert(textoFormatado.Length - 2, ",");

            if (textoFormatado != txtPrecoBruto.Texto)
                evitarLoopPrecoBruto = true;

            txtPrecoBruto.SelectionLength = 0;
            txtPrecoBruto.Texto = textoFormatado;
        }
    }
}
