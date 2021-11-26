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

                foreach (var item in vendaModel.ListaDeProdutos)
                    AtualizarEstoque(item, transacao);

                var idVenda = GerarVendaERetornarId(vendaModel, transacao);

                foreach (var item in vendaModel.ListaDeProdutos)
                {
                    item.IdVenda = idVenda;
                    CriarVendaProduto(item, transacao);
                }

                foreach (var itemPagamento in vendaModel.ListaPagamentos)
                {
                    itemPagamento.IdVenda = idVenda;
                    CriarFormaPagamento(itemPagamento, transacao);
                }

                transacao.Commit();
            }
            finally
            {
                _conexao.Close();
            }
        }

        private void AtualizarEstoque(VendaProdutoModel item, IDbTransaction transacao)
        {
            var quantidadeEstoque = _conexao.QuerySingle<int>(ProdutoSql.SelecionarQuantidade, new { id = item.IdProduto }, transacao);
            _conexao.Execute(ProdutoSql.AtualizarEstoque, new { Quantidade = quantidadeEstoque - item.Quantidade, id = item.IdProduto }, transacao);
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

                venda.DefinirCliente(_conexao.QuerySingleOrDefault<ClienteModel>(VendaSql.SelecionarClientePeloIdVenda, new { id }));
                venda.DefinirColaborador(_conexao.QuerySingleOrDefault<ColaboradorModel>(VendaSql.SelecionarColaboradorPeloIdVenda, new { id }));

                foreach (var item in _conexao.Query<VendaProdutoModel>(VendaSql.ListarTodosVendaProdutos, new { id }).ToList())
                    venda.ListaDeProdutos.Add(item);

                foreach (var pagamento in _conexao.Query<FormaPagamentoModel>(VendaSql.ListarTodasFormaPagamentos, new { id }).ToList())
                    venda.ListaPagamentos.Add(pagamento);

                return venda;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public void AtualizarVenda(VendaModel vendaModelAlterado)
        {
            var vendaModelAntigo = Selecionar(vendaModelAlterado.Id);

            try
            {
                _conexao.Open();
                using var transacao = _conexao.BeginTransaction();

                AtualizarClienteNaVenda(vendaModelAntigo.Cliente, vendaModelAlterado.Cliente, vendaModelAlterado.Id, transacao);
                AtualizarColaboradorNaVenda(vendaModelAntigo.Colaborador, vendaModelAlterado.Colaborador, vendaModelAlterado.Id, transacao);
                AtualizarProdutosNaVenda(vendaModelAlterado.Id, vendaModelAntigo.ListaDeProdutos, vendaModelAlterado.ListaDeProdutos, transacao);
                AtualizarFormaPagamentosNaVenda(vendaModelAlterado.Id, vendaModelAntigo.ListaPagamentos, vendaModelAlterado.ListaPagamentos, transacao);

                _conexao.Execute(@"
                update Venda set
                preco_bruto_total = @PrecoBrutoTotal,
                desconto_total = @DescontoTotal,
                preco_liquido_total = @PrecoLiquidoTotal",
                    VendaSql.RetornarParametroDinamicoParaInserirUm(vendaModelAlterado), transacao);

                transacao.Commit();
            }
            finally
            {
                _conexao.Close();
            }
        }

        private void AtualizarClienteNaVenda(ClienteModel clienteAntigo, ClienteModel clienteAlterado, int idVenda, IDbTransaction transacao)
        {
            if (clienteAntigo.IdUsuario == clienteAlterado.IdUsuario) return;

            _conexao.Execute("update Venda set id_cliente = @IdCliente where id = @Id", new { IdCliente = clienteAlterado.IdUsuario, Id = idVenda }, transacao);
        }

        private void AtualizarColaboradorNaVenda(ColaboradorModel colaboradorAntigo, ColaboradorModel colaboradorAlterado, int idVenda, IDbTransaction transacao)
        {
            if (colaboradorAntigo.IdUsuario == colaboradorAlterado.IdUsuario) return;

            _conexao.Execute("update Venda set id_colaborador = @IdColaborador where id = @Id", new { IdColaborador = colaboradorAlterado.IdUsuario, Id = idVenda }, transacao);
        }

        private void AtualizarProdutosNaVenda(int idVenda, IList<VendaProdutoModel> listaDeProdutosAntigo, IList<VendaProdutoModel> listaDeProdutosAlterado, IDbTransaction transacao)
        {
            foreach(var itemAlterado in listaDeProdutosAlterado)
            {
                if (itemAlterado.Id == 0)
                {
                    itemAlterado.IdVenda = idVenda;
                    AtualizarEstoque(itemAlterado, transacao);
                    CriarVendaProduto(itemAlterado, transacao);
                    continue;
                }

                var itemAntigo = listaDeProdutosAntigo.First(x => x.Id == itemAlterado.Id);
                if (itemAntigo != itemAlterado)
                    AtualizarVendaProduto(itemAlterado, transacao);

                listaDeProdutosAntigo.Remove(itemAntigo);
            }

            foreach(var itemRestante in listaDeProdutosAntigo)
                RemoverVendaProduto(itemRestante, transacao);
        }

        private void AtualizarVendaProduto(VendaProdutoModel itemAlterado, IDbTransaction transacao)
        {
            AtualizarEstoqueParaVendaAtualizada(itemAlterado, transacao);
            _conexao.Execute(@"
            update VendaProduto 
            set desconto = @Desconto, 
            quantidade = @Quantidade, 
            preco_bruto = @PrecoBruto, 
            lucro = @Lucro,
            preco_liquido = @PrecoLiquido where id = @Id", VendaSql.RetornarParametroDinamicoParaInserirUm(itemAlterado), transacao);
        }

        private void AtualizarEstoqueParaVendaAtualizada(VendaProdutoModel itemAlterado, IDbTransaction transacao)
        {
            var quantidadeEstoque = _conexao.QuerySingle<int>(ProdutoSql.SelecionarQuantidade, new { id = itemAlterado.IdProduto }, transacao);
            var quantidadeItemAntigo = _conexao.QuerySingle<int>(VendaSql.SelecionarQuantidadeVendaProduto, new { id = itemAlterado.Id }, transacao);

            _conexao.Execute(ProdutoSql.AtualizarEstoque, new { Quantidade = quantidadeEstoque + quantidadeItemAntigo - itemAlterado.Quantidade, id = itemAlterado.IdProduto }, transacao);
        }

        private void RemoverVendaProduto(VendaProdutoModel itemAlterado, IDbTransaction transacao)
        {
            AtualizarEstoqueParaRemoverVenda(itemAlterado, transacao);
            _conexao.Execute("delete from VendaProduto where id = @Id", new { itemAlterado.Id }, transacao);
        }

        private void AtualizarEstoqueParaRemoverVenda(VendaProdutoModel itemAlterado, IDbTransaction transacao)
        {
            var quantidadeEstoque = _conexao.QuerySingle<int>(ProdutoSql.SelecionarQuantidade, new { id = itemAlterado.IdProduto }, transacao);
            _conexao.Execute(ProdutoSql.AtualizarEstoque, new { Quantidade = quantidadeEstoque + itemAlterado.Quantidade, id = itemAlterado.IdProduto }, transacao);
        }

        private void AtualizarFormaPagamentosNaVenda(int idVenda, IList<FormaPagamentoModel> listaPagamentosAntigo, IList<FormaPagamentoModel> listaPagamentosAlterado, IDbTransaction transacao)
        {
            foreach (var itemAlterado in listaPagamentosAlterado)
            {
                if (itemAlterado.Id == 0)
                {
                    itemAlterado.IdVenda = idVenda;
                    CriarFormaPagamento(itemAlterado, transacao);
                    continue;
                }

                var itemAntigo = listaPagamentosAntigo.First(x => x.Id == itemAlterado.Id);
                if (itemAntigo != itemAlterado)
                    AtualizarFormaPagamento(itemAlterado, transacao);

                    listaPagamentosAntigo.Remove(itemAntigo);
            }

            foreach (var itemRestante in listaPagamentosAntigo)
                RemoverFormaPagamento(itemRestante, transacao);

        }

        private void AtualizarFormaPagamento(FormaPagamentoModel itemAlterado, IDbTransaction transacao)
        {
        }

        private void RemoverFormaPagamento(FormaPagamentoModel itemRestante, IDbTransaction transacao)
        {
        }
    }
}
