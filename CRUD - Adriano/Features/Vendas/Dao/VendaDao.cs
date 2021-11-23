using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.Produto.Sql;
using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.Sql;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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

        public IList<VendaModel> ListarTodosParaListagem()
        {
            try
            {
                _conexao.Open();

                var dicionarioVenda = new Dictionary<int, VendaModel>();
                _conexao.Query<VendaModel, ClienteModel, ColaboradorModel, VendaProdutoModel, VendaModel>(
                    @"select v.id, v.data_emissao as DataEmissao,
                    v.id as split, cl.nome, 
                    v.id as split, co.nome,
					v.id as split, vp.desconto, vp.quantidade, vp.preco_bruto as PrecoBruto, vp.lucro
					from Venda v
                    inner join Usuario cl on cl.id = v.id_cliente
                    inner join Usuario co on co.id = v.id_colaborador
					inner join VendaProduto vp on vp.id_venda = v.id", 
                    (vendaModel, clienteModel, colaboradorModel, vendaProdutoModel) => 
                        MapearListagemDeVenda(vendaModel, clienteModel, colaboradorModel, vendaProdutoModel, dicionarioVenda),
                    splitOn: "split").ToList();

                return dicionarioVenda.Values.ToList();
            }
            finally
            {
                _conexao.Close();
            }
        }

        private VendaModel MapearListagemDeVenda(VendaModel vendaModel, ClienteModel clienteModel, ColaboradorModel colaboradorModel, 
            VendaProdutoModel vendaProdutoModel, Dictionary<int, VendaModel> dicionarioVenda)
        {
            vendaModel.DefinirCliente(clienteModel);
            vendaModel.DefinirColaborador(colaboradorModel);

            if (dicionarioVenda.TryGetValue(vendaModel.Id, out var venda))
                venda.ListaDeProdutos.Add(vendaProdutoModel);
            else
            {
                vendaModel.ListaDeProdutos.Add(vendaProdutoModel);
                dicionarioVenda.Add(vendaModel.Id, vendaModel);
            }

            return vendaModel;
        }
    }
}
