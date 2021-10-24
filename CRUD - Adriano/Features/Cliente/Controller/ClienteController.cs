using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.Dao;
using CRUD___Adriano.Features.Factory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Cliente.Controller
{
    public class ClienteController : IControllerBase<ClienteModel>
    {
        private readonly ControllerConexao _conexao;

        public ClienteController(ControllerConexao conexao)
        {
            _conexao = conexao;
        }

        public bool Atualizar(ClienteModel clienteModel)
        {
            try
            {
                return _conexao.EscopoTransacaoComRetorno((conexao, transacao) => ClienteDao.AtualizarCliente(conexao, transacao, clienteModel));
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao atualizar o cliente");
            }
            return false;
        }

        public IList<ClienteModel> Listar()
        {
            try
            {
                return _conexao.EscopoConexaoComRetorno((conexao) => ClienteDao.ListarClientes(conexao));
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar clientes");
            }

            return new List<ClienteModel>();
        }

        public IList<ClienteModel> Listar(int quantidade)
        {
            throw new System.NotImplementedException();
        }

        public bool Remover(int id)
        {
            try
            {
                return _conexao.EscopoTransacaoComRetorno((conexao, transacao) => ClienteDao.RemoverCliente(conexao, transacao, id));
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao remover o cliente");
            }
            return false;
        }

        public bool Salvar(ClienteModel clienteModel)
        {
            try
            {
                return _conexao.EscopoTransacaoComRetorno((conexao, transacao) => ClienteDao.CadastrarCliente(conexao, transacao, clienteModel));
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao cadastrar cliente");
            }
            return false;
        }

        public ClienteModel Selecionar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
