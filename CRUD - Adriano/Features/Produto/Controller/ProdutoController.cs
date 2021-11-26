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

        public bool Atualizar(ProdutoModel produtoModel)
        {
            try
            {
                return _produtoDao.AtualizarProduto(produtoModel);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao atualizar o produto");
            }
            return false;
        }

        public IList<ProdutoModel> Listar()
        {
            try
            {
                return _produtoDao.ListarTodosOsProdutos();
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar produtos");
            }

            return new List<ProdutoModel>();
        }

        public IList<ProdutoModel> ListarSomenteIdENome()
        {
            try
            {
                return _produtoDao.ListarTodosOsProdutosSomenteIdENome();
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar produtos");
            }

            return new List<ProdutoModel>();
        }

        public IList<ProdutoModel> ListarPeloNomeSomenteIdENome(string nome)
        {
            try
            {
                return _produtoDao.ListarProdutosPeloNomeSomenteIdENome(nome);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar produtos");
            }

            return new List<ProdutoModel>();
        }

        public IList<ProdutoModel> ListarPelaQuantidadeSomenteIdENome(int quantidade)
        {
            try
            {
                return _produtoDao.ListarPelaQuantidadeSomenteIdENome(quantidade);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar produtos");
            }

            return new List<ProdutoModel>();
        }

        public bool Remover(int id)
        {
            try
            {
                return _produtoDao.TrocarStatusDoProduto(id);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao inativar o produto");
            }
            return false;
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
            try
            {
                return _produtoDao.SelecionarProduto(id);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao buscar o produto");
            }
            return new ProdutoModel();
        }

        public ProdutoModel SelecionarPeloIdSomenteIdENome(int id)
        {
            try
            {
                return _produtoDao.SelecionarProdutoSomenteIdENome(id);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao buscar o produto");
            }
            return new ProdutoModel();
        }

        public bool SalvarLista(IList<ProdutoModel> listaDeProdutos)
        {
            try
            {
                foreach (var produtoModel in listaDeProdutos)
                    _produtoDao.CadastrarProduto(produtoModel);

                return true;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao cadastrar lista de produtos");
            }
            return false;
        }
    }
}
