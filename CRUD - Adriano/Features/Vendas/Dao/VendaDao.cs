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
                    VendaSql.ListarTodos, 
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

        public void Remover(int id)
        {
            try
            {
                _conexao.Open();
                using var transacao = _conexao.BeginTransaction();

                _conexao.Execute(VendaSql.RemoverVendaProduto, new { id }, transacao);
                _conexao.Execute(VendaSql.RemoverFormaPagamento, new { id }, transacao);
                _conexao.Execute(VendaSql.RemoverVenda, new { id }, transacao);

                transacao.Commit();
            }
            finally
            {
                _conexao.Close();
            }
        }

        public VendaModel Selecionar(int id)
        {
            try
            {
                _conexao.Open();
                var venda = _conexao.QuerySingleOrDefault<VendaModel>(@"select id, data_emissao from Venda where id = @id", new { id });

                venda.DefinirCliente(_conexao.QuerySingleOrDefault<ClienteModel>(@"select u.id as IdUsuario, u.nome from Venda v inner join Usuario u on u.id = v.id_cliente where v.id = @id", new { id }));
                venda.DefinirColaborador(_conexao.QuerySingleOrDefault<ColaboradorModel>(@"select u.id as IdUsuario, u.nome from Venda v inner join Usuario u on u.id = v.id_colaborador where v.id = @id", new { id }));

                foreach (var item in _conexao.Query<VendaProdutoModel>(@"select v.id, p.nome, v.desconto, v.quantidade, v.preco_bruto as PrecoBruto, v.lucro 
                from VendaProduto v
                inner join Produto p on p.id = v.id_produto
                where id_venda = @id", new { id }).ToList())
                    venda.ListaDeProdutos.Add(item);

                foreach (var pagamento in _conexao.Query<FormaPagamentoModel>(@"select id, posicao_pagamento as PosicaoPagamento, valor_pago as ValorAPagar, tipo_pagamento as TipoPagamento, quantidade_parcelas as QuantidadeParcelas, posicao_parcela as PosicaoParcela from FormaPagamento where id_venda = @id", new { id }).ToList())
                    venda.ListaPagamentos.Add(pagamento);

                return venda;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public void AtualizarVenda(VendaModel vendaModelModificado)
        {
            var vendaModelAntigo = Selecionar(vendaModelModificado.Id);


        }
    }
}
