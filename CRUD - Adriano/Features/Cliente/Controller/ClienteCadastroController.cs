using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cadastro.Produto.View;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cadastro.Produto.Controller
{
    public class ClienteCadastroController
    {
        private FrmCadastroCliente _frmCadastroProduto;

        public ClienteCadastroController() =>
            _frmCadastroProduto = new FrmCadastroCliente(this);

        public void AbrirFormulario() =>
            _frmCadastroProduto.Show();

        public Form RetornarFormulario() =>
            _frmCadastroProduto;

        public void EfetuarCadastroDoProduto()
        {
            /*int.TryParse(_frmCadastroProduto.txtQuantidade.Text, out int quantidade);
            if (!ValidarCadastro())
                MessageBox.Show("Campos inválidos!");

            CadastrarProduto(new ClienteModel
            {
                Nome = _frmCadastroProduto.txtNome.Text,
            });*/
        }

        /*public bool ValidarCadastro() =>
            !(_frmCadastroProduto.txtNome.Text.Equals(string.Empty) || _frmCadastroProduto.txtQuantidade.Text.Equals(string.Empty));*/

        public void CadastrarProduto(ClienteModel produto)
        {
            
        }
    }
}
