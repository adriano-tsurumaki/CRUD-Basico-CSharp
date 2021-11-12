using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Produto.Dao;
using CRUD___Adriano.Features.Produto.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Produto.Controller
{
    public class ProdutoController : IControllerBase<ProdutoModel>, IControllerListarIdNome<ProdutoModel>
    {
        private readonly ProdutoDao _produtoDao;

        public ProdutoController(ProdutoDao produtoDao)
        {
            _produtoDao = produtoDao;
        }

        public bool Atualizar(ProdutoModel entidade)
        {
            throw new System.NotImplementedException();
        }

        public IList<ProdutoModel> Listar()
        {
            throw new System.NotImplementedException();
        }

        public IList<ProdutoModel> ListarPelaQuantidadeSomenteIdENome(int quantidade)
        {
            throw new System.NotImplementedException();
        }

        public IList<ProdutoModel> ListarPeloNomeSomenteIdENome(string nome)
        {
            throw new System.NotImplementedException();
        }

        public IList<ProdutoModel> ListarSomenteIdENome()
        {
            throw new System.NotImplementedException();
        }

        public bool Remover(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Salvar(ProdutoModel produtoModel)
        {
            try
            {
                return _produtoDao.CadastrarProduto(produtoModel);
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao cadastrar o produto!");
            }
            return false;
        }

        public ProdutoModel Selecionar(int id)
        {
            throw new System.NotImplementedException();
        }

        public ProdutoModel SelecionarPeloIdSomenteIdENome(int id)
        {
            throw new NotImplementedException();
        }
    }
}
