using CRUD___Adriano.Features.Vendas.Dao;
using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class PesquisarProdutoController
    {
        private readonly VendaProdutoDao _vendaProdutoDao;
        private readonly UcPesquisarProduto _ucPesquisarProduto;

        public PesquisarProdutoController(VendaProdutoDao vendaProdutoDao)
        {
            _vendaProdutoDao = vendaProdutoDao;
            _ucPesquisarProduto = new UcPesquisarProduto(this);
        }

        public UcPesquisarProduto RetornarUserControl() => _ucPesquisarProduto;

        public VendaProdutoModel PesquisarProdutoPeloId(int id)
        {
            try
            {
                return _vendaProdutoDao.SelecionarProdutoPeloId(id);
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao pesquisar o produto por id!");
            }

            return new VendaProdutoModel();
        }

        public IList<VendaProdutoModel> PesquisarProdutoPeloNome(string nome)
        {
            try
            {
                return _vendaProdutoDao.SelecionarProdutoPeloNome(nome);
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao pesquisar os produtos pelo nome!");
            }

            return new List<VendaProdutoModel>();
        }

        public IList<VendaProdutoModel> PesquisarTodosOsProdutos()
        {
            try
            {
                return _vendaProdutoDao.ListarTodosParaVenda();
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro ao listar todos os produtos!");
            }

            return new List<VendaProdutoModel>();
        }
    }
}
