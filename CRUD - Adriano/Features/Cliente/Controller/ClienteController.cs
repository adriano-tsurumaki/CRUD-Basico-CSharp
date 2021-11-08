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
        private readonly ClienteDao _clienteDao;

        public ClienteController(ClienteDao clienteDao)
        {
            _clienteDao = clienteDao;
        }

        public bool Atualizar(ClienteModel clienteModel)
        {
            try
            {
                return _clienteDao.AtualizarCliente(clienteModel);
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
                return _clienteDao.ListarTodosOsClientes();
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
                return _clienteDao.ListarTodosOsClientesSomenteIdENome();
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
                return _clienteDao.ListarClientesPeloNomeSomenteIdENome(nome);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar clientes");
            }

            return new List<ClienteModel>();
        }

        public IList<ClienteModel> ListarPelaQuantidadeSomenteIdENome(int quantidade)
        {
            try
            {
                return _clienteDao.ListarPelaQuantidadeSomenteIdENome(quantidade);
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
                return _clienteDao.RemoverCliente(id);
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
                return _clienteDao.CadastrarCliente(clienteModel);
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
                    _clienteDao.CadastrarCliente(clienteModel);

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
            try
            {
                return _clienteDao.SelecionarCliente(id);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao buscar o cliente");
            }
            return new ClienteModel();
        }

        public ClienteModel SelecionarSomenteIdENome(int id)
        {
            try
            {
                return _clienteDao.SelecionarClienteSomenteIdENome(id);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao buscar o cliente");
            }
            return new ClienteModel();
        }
    }
}
