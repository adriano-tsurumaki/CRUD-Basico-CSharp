using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.Dao;
using CRUD___Adriano.Features.Cliente.Model;
using CRUD___Adriano.Features.Factory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.Controller
{
    public class ClienteController : IClienteController
    {
        private ControllerConexao _conexao;

        public ClienteController(ControllerConexao conexao)
        {
            _conexao = conexao;
        }

        public void Atualizar(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<ClienteModel> Listar(int quantidade)
        {
            throw new System.NotImplementedException();
        }

        public void Salvar(ClienteModel clienteModel)
        {
            try
            {
                _conexao.EscopoTransacao((conexao, transacao) => ClienteDao.CadastrarCliente(conexao, transacao, clienteModel));
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao cadastrar cliente");
            }
        }

        public ClienteModel Selecionar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
