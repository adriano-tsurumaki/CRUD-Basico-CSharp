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
        private ControllerConexao _conexao;

        public void Atualizar(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<ColaboradorModel> Listar(int quantidade)
        {
            throw new System.NotImplementedException();
        }

        public void Salvar(ColaboradorModel colaboradorModel)
        {
            try
            {
                _conexao.EscopoTransacao((conexao, transacao) => ColaboradorDao.CadastrarColaborador(conexao, transacao, colaboradorModel));
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao cadastrar colaborador");
            }
        }

        public ColaboradorModel Selecionar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
