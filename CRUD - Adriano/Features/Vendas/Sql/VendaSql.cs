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

        public static readonly string ListarTodos = @"select v.id, v.data_emissao as DataEmissao,
            v.id as split, cl.nome, 
            v.id as split, co.nome,
		    v.id as split, vp.desconto, vp.quantidade, vp.preco_bruto as PrecoBruto, vp.lucro
		    from Venda v
            inner join Usuario cl on cl.id = v.id_cliente
            inner join Usuario co on co.id = v.id_colaborador
		    inner join VendaProduto vp on vp.id_venda = v.id";

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

        public static readonly string RemoverVenda =
            @"delete from Venda where id = @Id";

        public static readonly string RemoverVendaProduto =
            @"delete from VendaProduto where id_venda = @Id";

        public static readonly string RemoverFormaPagamento =
            @"delete from FormaPagamento where id_venda = @Id";

        public static readonly string Selecionar =
            @"select v.id, v.data_emissao as DataEmissao,
            v.id as split, cl.id as IdUsuario, cl.nome, 
            v.id as split, co.id as IdUsuario, co.nome,
		    v.id as split, vp.desconto, vp.quantidade, vp.preco_bruto as PrecoBruto, vp.lucro,
			v.id as split, fp.id, fp.posicao_pagamento as PosicaoPagamento, fp.valor_pago as ValorAPagar, fp.tipo_pagamento as TipoPagamento, fp.quantidade_parcelas as QuantidadeParcelas, fp.posicao_parcela as PosicaoParcela
		    from Venda v
            inner join Usuario cl on cl.id = v.id_cliente
            inner join Usuario co on co.id = v.id_colaborador
		    inner join VendaProduto vp on vp.id_venda = v.id
			inner join FormaPagamento fp on fp.id_venda = v.id
			where v.id = @id";

        public static readonly string SelecionarClientePeloIdVenda =
            @"select u.id as IdUsuario, u.nome 
            from Venda v 
            inner join Usuario u on u.id = v.id_cliente 
            where v.id = @id";

        public static readonly string SelecionarColaboradorPeloIdVenda =
            @"select u.id as IdUsuario, u.nome 
            from Venda v 
            inner join Usuario u on u.id = v.id_colaborador 
            where v.id = @id";

        public static readonly string ListarTodosVendaProdutos =
            @"select v.id, v.id_produto as IdProduto, v.id_venda as IdVenda, p.nome, v.desconto, v.quantidade, v.preco_bruto as PrecoBruto, v.lucro 
                from VendaProduto v
                inner join Produto p on p.id = v.id_produto
                where id_venda = @id";

        public static readonly string ListarTodasFormaPagamentos =
            @"select id, posicao_pagamento as PosicaoPagamento, valor_pago as ValorAPagar, 
            tipo_pagamento as TipoPagamento, quantidade_parcelas as QuantidadeParcelas, posicao_parcela as PosicaoParcela 
            from FormaPagamento where id_venda = @id";

        public static readonly string SelecionarQuantidadeVendaProduto =
            @"select quantidade from VendaProduto where id = @id";


        public static DynamicParameters RetornarParametroDinamicoParaInserirUm(VendaModel vendaModel)
        {
            var parametros = new DynamicParameters();

            parametros.AddDynamicParams(new
            {
                vendaModel.Id,
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
                vendaProdutoModel.Id,
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
