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

        public bool Atualizar(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<ColaboradorModel> Listar()
        {
            throw new System.NotImplementedException();
        }

        public IList<ColaboradorModel> Listar(int quantidade)
        {
            throw new System.NotImplementedException();
        }

        public bool Remover(int id)
        {
            throw new NotImplementedException();
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
