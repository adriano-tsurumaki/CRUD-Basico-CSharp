using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cadastro.Produto.View;
using CRUD___Adriano.Features.Configuration;
using CRUD___Adriano.Features.Cliente.Dao;
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

        public void CadastrarCliente(ClienteModel clienteModel)
        {
            try
            {
                using (var conexao = SqlConexao.RetornarConexao())
                {
                    conexao.Open();
                    ClienteDao.CadastrarCliente(conexao, clienteModel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(_frmCadastroProduto, ex.Message, "Erro ao cadastrar cliente");
            }
        }
    }
}
