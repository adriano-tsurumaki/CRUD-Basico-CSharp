using CRUD___Adriano.Features.Vendas.Model;
using Dapper;

namespace CRUD___Adriano.Features.Vendas.Sql
{
    public static class VendaSql
    {
        public readonly static string SelecionarProdutoVendaPorId =
            @"select id as IdProduto, nome, preco_bruto as PrecoBruto, lucro from Produto where id = @id and ativo = 1 and quantidade > 0";

        public readonly static string SelecionarProdutoVendaPeloNome =
            @"select id as IdProduto, nome, preco_bruto as PrecoBruto, lucro from Produto where nome Like @nome + '%' and ativo = 1 and quantidade > 0";

        public static readonly string ListarTodosParaVenda =
            @"select id as IdProduto, nome, preco_bruto as PrecoBruto, lucro from Produto where quantidade > 0";

        public static readonly string InserirVenda =
            @"insert into Venda (id_cliente, id_colaborador, preco_bruto_total, desconto_total, preco_liquido_total)
            output inserted.id
            values (@IdCliente, @IdColaborador, @PrecoBrutoTotal, @DescontoTotal, @PrecoLiquidoTotal)";

        public static readonly string InserirVendaProduto =
            @"insert into VendaProduto (id_produto, id_venda, desconto, quantidade, preco_bruto, lucro, preco_liquido)
            values (@IdProduto, @IdVenda, @Desconto, @Quantidade, @PrecoBruto, @Lucro, @PrecoLiquido)";
        
        public static readonly string InserirFormaPagamento =
            @"insert into FormaPagamento (id_venda, posicao_pagamento, valor_pago, tipo_pagamento, quantidade_parcelas, posicao_parcela)
            values (@IdVenda, @PosicaoPagamento, @ValorPago, @TipoPagamento, @QuantidadeParcelas, @PosicaoParcela)";


        public static DynamicParameters RetornarParametroDinamicoParaInserirUm(VendaModel vendaModel)
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new
            {
                IdCliente = vendaModel.Cliente.IdUsuario,
                IdColaborador = vendaModel.Colaborador.IdUsuario,
                PrecoBrutoTotal = vendaModel.ValorBrutoTotal.Valor,
                DescontoTotal = vendaModel.DescontoTotal.Valor,
                PrecoLiquidoTotal = vendaModel.ValorLiquidoTotal.Valor,
            });

            return parametros;
        }

        public static DynamicParameters RetornarParametroDinamicoParaInserirUm(VendaProdutoModel vendaProdutoModel)
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new
            {
                vendaProdutoModel.IdProduto,
                vendaProdutoModel.IdVenda,
                Desconto = vendaProdutoModel.Desconto.Valor,
                vendaProdutoModel.Quantidade,
                PrecoBruto = vendaProdutoModel.PrecoBruto.Valor,
                vendaProdutoModel.Lucro,
                PrecoLiquido = vendaProdutoModel.PrecoLiquido.Valor,
            });

            return parametros;
        }

        public static DynamicParameters RetornarParametroDinamicoParaInserirUm(FormaPagamentoModel formaPagamentoModel)
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new
            {
                formaPagamentoModel.IdVenda,
                formaPagamentoModel.PosicaoPagamento,
                ValorPago = formaPagamentoModel.ValorAPagar.Valor,
                formaPagamentoModel.TipoPagamento,
                formaPagamentoModel.QuantidadeParcelas,
                formaPagamentoModel.PosicaoParcela
            });

            return parametros;
        }
    }
}
