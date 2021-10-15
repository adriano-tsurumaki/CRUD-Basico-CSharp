using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cadastro.Produto.View;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cadastro.Produto.Controller
{
    public class ProdutoCadastroController
    {
        private FrmCadastroProduto _frmCadastroProduto;

        public ProdutoCadastroController() =>
            _frmCadastroProduto = new FrmCadastroProduto(this);

        public void AbrirFormulario() =>
            _frmCadastroProduto.Show();

        public void EfetuarCadastroDoProduto()
        {
            int.TryParse(_frmCadastroProduto.txtQuantidade.Text, out int quantidade);
            if (!ValidarCadastro())
                MessageBox.Show("Campos inválidos!");

            CadastrarProduto(new ProdutoModel
            {
                Nome = _frmCadastroProduto.txtNome.Text,
                Quantidade = quantidade
            });
        }

        public bool ValidarCadastro() =>
            !(_frmCadastroProduto.txtNome.Text.Equals(string.Empty) || _frmCadastroProduto.txtQuantidade.Text.Equals(string.Empty));

        public void CadastrarProduto(ProdutoModel produto)
        {
            
        }
    }
}
