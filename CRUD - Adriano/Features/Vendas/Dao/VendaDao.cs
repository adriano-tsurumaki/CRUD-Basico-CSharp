using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Produto.Dao;
using CRUD___Adriano.Features.Produto.Sql;
using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.Sql;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace CRUD___Adriano.Features.Vendas.Dao
{
    public class VendaDao
    {
        private IDbConnection _conexao;

        public VendaDao(IDbConnection conexao)
        {
            _conexao = conexao;
        }

        public void EfetuarVenda(VendaModel vendaModel)
        {
            try
            {
                _conexao.Open();
                using var transacao = _conexao.BeginTransaction();

                AtualizarEstoques(vendaModel.ListaDeProdutos, transacao);

                var idVenda = GerarVendaERetornarId(vendaModel, transacao);

                foreach (var item in vendaModel.ListaDeProdutos)
                {
                    item.IdVenda = idVenda;
                    CriarVendaProduto(item, transacao);
                }

                foreach (var item in vendaModel.ListaPagamentos)
                {
                    item.IdVenda = idVenda;
                    CriarFormaPagamento(item, transacao);
                }

                transacao.Commit();
            }
            finally
            {
                _conexao.Close();
            }
        }

        private void AtualizarEstoques(IList<VendaProdutoModel> listaDeProdutos, IDbTransaction transacao)
        {
            foreach (var item in listaDeProdutos)
            {
                var quantidadeEstoque = _conexao.QuerySingle<int>(ProdutoSql.SelecionarQuantidade, new { id = item.IdProduto }, transacao);
                _conexao.Execute(ProdutoSql.AtualizarEstoque, new { Quantidade = quantidadeEstoque - item.Quantidade, id = item.IdProduto }, transacao);
            }
        }

        private int GerarVendaERetornarId(VendaModel vendaModel, IDbTransaction transacao)
        {
            return _conexao.ExecuteScalar<int>(VendaSql.InserirVenda, VendaSql.RetornarParametroDinamicoParaInserirUm(vendaModel), transacao);
        }

        private void CriarVendaProduto(VendaProdutoModel vendaProdutoModel, IDbTransaction transacao)
        {
            _conexao.Execute(VendaSql.InserirVendaProduto, VendaSql.RetornarParametroDinamicoParaInserirUm(vendaProdutoModel), transacao);
        }

        private void CriarFormaPagamento(FormaPagamentoModel formaPagamentoModel, IDbTransaction transacao)
        {
            _conexao.Execute(VendaSql.InserirFormaPagamento, VendaSql.RetornarParametroDinamicoParaInserirUm(formaPagamentoModel), transacao);
        }
    }
}
