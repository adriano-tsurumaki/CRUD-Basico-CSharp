using CRUD___Adriano.Features.Cliente.Model;
using CRUD___Adriano.Features.Colaborador.Dao;
using CRUD___Adriano.Features.Factory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Colaborador.Controller
{
    public class ColaboradorController : IControllerBase<ColaboradorModel>
    {
        private readonly ControllerConexao _conexao;

        public ColaboradorController(ControllerConexao conexao)
        {
            _conexao = conexao;
        }

        public bool Atualizar(ColaboradorModel colaboradorModel)
        {
            try
            {
                return _conexao.EscopoTransacaoComRetorno((conexao, transacao) => ColaboradorDao.AtualizarColaborador(conexao, transacao, colaboradorModel));
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
                return _conexao.EscopoConexaoComRetorno((conexao) => ColaboradorDao.ListarColaborador(conexao));
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar colaboradores");
            }

            return new List<ColaboradorModel>();
        }

        public IList<ColaboradorModel> ListarSomenteIdENome()
        {
            try
            {
                return _conexao.EscopoConexaoComRetorno((conexao) => ColaboradorDao.ListarTodosOsColaboradoresSomenteIdENome(conexao));
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar colaboradores");
            }

            return new List<ColaboradorModel>();
        }

        public IList<ColaboradorModel> Listar(int quantidade)
        {
            throw new System.NotImplementedException();
        }

        public bool Remover(int id)
        {
            try
            {
                return _conexao.EscopoTransacaoComRetorno((conexao, transacao) => ColaboradorDao.RemoverColaborador(conexao, transacao, id));
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
                return _conexao.EscopoTransacaoComRetorno((conexao, transacao) => ColaboradorDao.CadastrarColaborador(conexao, transacao, colaboradorModel));
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao cadastrar colaborador");

                return false;
            }
        }

        public ColaboradorModel Selecionar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
