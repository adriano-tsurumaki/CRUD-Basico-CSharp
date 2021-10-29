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
                return _conexao.EscopoConexaoComRetorno((conexao) => ClienteDao.ListarTodosOsClientes(conexao));
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar clientes");
            }

            return new List<ClienteModel>();
        }

        public IList<ClienteModel> ListarSomenteIdENome()
        {
            try
            {
                return _conexao.EscopoConexaoComRetorno((conexao) => ClienteDao.ListarTodosOsClientesSomenteIdENome(conexao));
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar clientes");
            }

            return new List<ClienteModel>();
        }

        public IList<ClienteModel> ListarPeloNomeSomenteIdENome(string nome)
        {
            try
            {
                return _conexao.EscopoConexaoComRetorno((conexao) => ClienteDao.ListarClientesPeloNomeSomenteIdENome(conexao, nome));
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar clientes");
            }

            return new List<ClienteModel>();
        }

        public IList<ClienteModel> Listar(int quantidade)
        {
            try
            {
                return _conexao.EscopoConexaoComRetorno((conexao) => ClienteDao.ListarAlgunsClientesSomenteIdENome(conexao, quantidade));
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar clientes");
            }

            return new List<ClienteModel>();
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

        public bool SalvarLista(IList<ClienteModel> listaDeClientes)
        {
            try
            {
                foreach (var clienteModel in listaDeClientes)
                    _conexao.EscopoTransacao((conexao, transacao) => ClienteDao.CadastrarCliente(conexao, transacao, clienteModel));

                return true;
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao cadastrar lista de clientes");
            }
            return false;
        }

        public ClienteModel Selecionar(int id)
        {
            throw new System.NotImplementedException();
        }

        public ClienteModel SelecionarSomenteIdENome(int id)
        {
            try
            {
                return _conexao.EscopoConexaoComRetorno((conexao) => ClienteDao.SelecionarClienteSomenteIdENome(conexao, id));
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao buscar o cliente");
            }
            return new ClienteModel();
        }
    }
}
