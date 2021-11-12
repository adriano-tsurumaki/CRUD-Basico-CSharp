using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Fornecedor.Dao;
using CRUD___Adriano.Features.Fornecedor.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Fornecedor.Controller
{
    public class FornecedorController : IControllerBase<FornecedorModel>, IControllerListarIdNome<FornecedorModel>
    {
        private readonly FornecedorDao _fornecedorDao;

        public FornecedorController(FornecedorDao fornecedorDao)
        {
            _fornecedorDao = fornecedorDao;
        }

        public bool Atualizar(FornecedorModel fornecedorModel)
        {
            throw new NotImplementedException();
        }

        public IList<FornecedorModel> Listar()
        {
            throw new NotImplementedException();
        }

        public IList<FornecedorModel> ListarSomenteIdENome()
        {
            try
            {
                return _fornecedorDao.ListarTodosOsFornecedoresSomenteIdENome();
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar os fornecedores");
            }

            return new List<FornecedorModel>();
        }

        public IList<FornecedorModel> ListarPeloNomeSomenteIdENome(string nome)
        {
            try
            {
                return _fornecedorDao.ListarFornecedoresPeloNomeSomenteIdENome(nome);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar fornecedores");
            }

            return new List<FornecedorModel>();
        }

        public IList<FornecedorModel> ListarPelaQuantidadeSomenteIdENome(int quantidade)
        {
            try
            {
                return _fornecedorDao.ListarPelaQuantidadeSomenteIdENome(quantidade);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar fornecedores");
            }

            return new List<FornecedorModel>();
        }

        public bool Remover(int id)
        {
            throw new NotImplementedException();
        }

        public bool Salvar(FornecedorModel fornecedorModel)
        {
            try
            {
                return _fornecedorDao.CadastrarFornecedor(fornecedorModel);
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao cadastrar o fornecedor");
            }
            return false;
        }

        public bool SalvarLista(IList<FornecedorModel> listaDeFornecedores)
        {
            try
            {
                foreach (var fornecedorModel in listaDeFornecedores)
                    _fornecedorDao.CadastrarFornecedor(fornecedorModel);

                return true;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao cadastrar lista de colaboradores");
            }
            return false;
        }

        public FornecedorModel Selecionar(int id)
        {
            throw new NotImplementedException();
        }

        public FornecedorModel SelecionarPeloIdSomenteIdENome(int id)
        {
            try
            {
                return _fornecedorDao.SelecionarClienteSomenteIdENome(id);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao buscar o fornecedor");
            }
            return new FornecedorModel();
        }
    }
}
