using CRUD___Adriano.Features.Colaborador.Dao;
using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.Factory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Colaborador.Controller
{
    public class ColaboradorController : IControllerBase<ColaboradorModel>, IControllerListarIdNome<ColaboradorModel>
    {
        private readonly ColaboradorDao _colaboradorDao;

        public ColaboradorController(ColaboradorDao colaboradorDao)
        {
            _colaboradorDao = colaboradorDao;
        }

        public bool Atualizar(ColaboradorModel colaboradorModel)
        {
            try
            {
                return _colaboradorDao.AtualizarColaborador(colaboradorModel);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao atualizar o colaborador");
            }
            return false;
        }

        public IList<ColaboradorModel> Listar()
        {
            try
            {
                return _colaboradorDao.ListarColaborador();
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar colaboradores");
            }

            return new List<ColaboradorModel>();
        }

        public bool SalvarLista(IList<ColaboradorModel> listaDeColaboradores)
        {
            try
            {
                foreach (var colaboradorModel in listaDeColaboradores)
                    _colaboradorDao.CadastrarColaborador(colaboradorModel);

                return true;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao cadastrar lista de colaboradores");
            }
            return false;
        }

        public IList<ColaboradorModel> ListarSomenteIdENome()
        {
            try
            {
                return _colaboradorDao.ListarTodosOsColaboradoresSomenteIdENome();
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar colaboradores");
            }

            return new List<ColaboradorModel>();
        }

        public IList<ColaboradorModel> ListarPelaQuantidadeSomenteIdENome(int quantidade)
        {
            try
            {
                return _colaboradorDao.ListarPelaQuantidadeSomenteIdENome(quantidade);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar colaboradores");
            }

            return new List<ColaboradorModel>();
        }

        public IList<ColaboradorModel> ListarPeloNomeSomenteIdENome(string nome)
        {
            try
            {
                return _colaboradorDao.ListarColaboradoresPeloNomeSomenteIdENome(nome);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar colaboradores");
            }

            return new List<ColaboradorModel>();
        }

        public bool Remover(int id)
        {
            try
            {
                return _colaboradorDao.RemoverColaborador(id);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao remover o colaborador");
            }
            return false;
        }

        public bool Salvar(ColaboradorModel colaboradorModel)
        {
            try
            {
                return _colaboradorDao.CadastrarColaborador(colaboradorModel);
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao cadastrar colaborador");

                return false;
            }
        }

        public ColaboradorModel Selecionar(int id)
        {
            try
            {
                return _colaboradorDao.SelecionarColaborador(id);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao buscar o colaborador");
            }
            return new ColaboradorModel();
        }

        public ColaboradorModel SelecionarSomenteIdENome(int id)
        {
            try
            {
                return _colaboradorDao.SelecionarColaboradorSomenteIdENome(id);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao buscar o colaborador");
            }
            return new ColaboradorModel();
        }
    }
}
