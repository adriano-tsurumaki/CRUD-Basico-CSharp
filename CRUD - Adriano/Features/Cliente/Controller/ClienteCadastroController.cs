using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cadastro.Usuario.View;
using CRUD___Adriano.Features.Configuration;
using CRUD___Adriano.Features.Cliente.Dao;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CRUD___Adriano.Features.Cadastro.Produto.Controller
{
    public class ClienteCadastroController
    {
        private FrmCadastroUsuario _frmCadastroProduto;

        public ClienteCadastroController()
        {
        }

        public void AbrirFormulario() =>
            _frmCadastroProduto.Show();

        public Form RetornarFormulario() =>
            _frmCadastroProduto;

        public void CadastrarCliente(ClienteModel clienteModel)
        {
            try
            {
                using var conexao = SqlConexao.RetornarConexao();
                conexao.Open();

                using var transacao = conexao.BeginTransaction();
                ClienteDao.CadastrarCliente(conexao, transacao, clienteModel);

                transacao.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(_frmCadastroProduto, ex.Message, "Erro ao cadastrar cliente");
            }
        }
    }
}
