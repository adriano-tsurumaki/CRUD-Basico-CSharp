using CRUD___Adriano.Features.Relatório.Dao;
using CRUD___Adriano.Features.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Teste_Unitário.Relatório.Dao
{
    [TestClass]
    public class FiltroRelatorioVendaProdutoDeveria
    {
        [DataTestMethod]
        [DynamicData(nameof(Lista_para_gerar_sql), DynamicDataSourceType.Method)]
        public void Deveria_gerar_sql_filtrado_corretamente(FiltroRelatorioVendaProduto filtro, string sqlEsperado) =>
            Assert.AreEqual(filtro.GerarSql(), sqlEsperado.RemoverExcessoDeEspaçoEmBranco());

        public static IEnumerable<object[]> Lista_para_gerar_sql() =>
            new List<object[]>
            {
                new object[]
                {
                    new FiltroRelatorioVendaProduto(),
                    @"select p.id as IdProduto, p.nome as NomeProduto, 
                    sum(vp.quantidade) as Quantidade, 
                    sum(vp.preco_bruto * vp.quantidade) as PrecoBrutoTotal, 
                    sum(vp.desconto * vp.quantidade) as DescontoTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) as LucroTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) / sum(vp.preco_bruto * vp.quantidade) * 100 as LucroTotalPorcentagem, 
                    sum(vp.preco_liquido) as PrecoLiquidoTotal 
                    from VendaProduto vp 
                    inner join Produto p on p.id = vp.id_produto 
                    group by p.nome, p.id "
                },
                new object[]
                {
                    new FiltroRelatorioVendaProduto
                    {
                        IdCliente = 1
                    },
                    @"select p.id as IdProduto, p.nome as NomeProduto, 
                    sum(vp.quantidade) as Quantidade, 
                    sum(vp.preco_bruto * vp.quantidade) as PrecoBrutoTotal, 
                    sum(vp.desconto * vp.quantidade) as DescontoTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) as LucroTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) / sum(vp.preco_bruto * vp.quantidade) * 100 as LucroTotalPorcentagem, 
                    sum(vp.preco_liquido) as PrecoLiquidoTotal, 
                    u.nome as NomeCliente, 
                    u.id as IdCliente 
                    from VendaProduto vp 
                    inner join Produto p on p.id = vp.id_produto 
                    inner join Venda v on v.id = vp.id_venda 
                    inner join Usuario u on u.id = v.id_cliente 
                    group by p.nome, p.id, u.id, u.nome 
                    having u.id = @IdCliente "
                },
                new object[]
                {
                    new FiltroRelatorioVendaProduto
                    {
                        IdProduto = 1
                    },
                    @"select p.id as IdProduto, p.nome as NomeProduto, 
                    sum(vp.quantidade) as Quantidade, 
                    sum(vp.preco_bruto * vp.quantidade) as PrecoBrutoTotal, 
                    sum(vp.desconto * vp.quantidade) as DescontoTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) as LucroTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) / sum(vp.preco_bruto * vp.quantidade) * 100 as LucroTotalPorcentagem, 
                    sum(vp.preco_liquido) as PrecoLiquidoTotal 
                    from VendaProduto vp 
                    inner join Produto p on p.id = vp.id_produto 
                    group by p.nome, p.id 
                    having p.id = @IdProduto "
                },
                new object[]
                {
                    new FiltroRelatorioVendaProduto
                    {
                        IdCliente = 1,
                        IdProduto = 1
                    },
                    @"select p.id as IdProduto, p.nome as NomeProduto, 
                    sum(vp.quantidade) as Quantidade, 
                    sum(vp.preco_bruto * vp.quantidade) as PrecoBrutoTotal, 
                    sum(vp.desconto * vp.quantidade) as DescontoTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) as LucroTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) / sum(vp.preco_bruto * vp.quantidade) * 100 as LucroTotalPorcentagem, 
                    sum(vp.preco_liquido) as PrecoLiquidoTotal, 
                    u.nome as NomeCliente, 
                    u.id as IdCliente 
                    from VendaProduto vp 
                    inner join Produto p on p.id = vp.id_produto 
                    inner join Venda v on v.id = vp.id_venda 
                    inner join Usuario u on u.id = v.id_cliente 
                    group by p.nome, p.id, u.id, u.nome 
                    having u.id = @IdCliente and p.id = @IdProduto "
                },
                new object[]
                {
                    new FiltroRelatorioVendaProduto
                    {
                        DataInicio = DateTime.Now,
                        DataFinal = DateTime.Now,
                    },
                    @"select p.id as IdProduto, p.nome as NomeProduto, 
                    sum(vp.quantidade) as Quantidade, 
                    sum(vp.preco_bruto * vp.quantidade) as PrecoBrutoTotal, 
                    sum(vp.desconto * vp.quantidade) as DescontoTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) as LucroTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) / sum(vp.preco_bruto * vp.quantidade) * 100 as LucroTotalPorcentagem, 
                    sum(vp.preco_liquido) as PrecoLiquidoTotal 
                    from VendaProduto vp 
                    inner join Produto p on p.id = vp.id_produto 
                    inner join Venda v on v.id = vp.id_venda 
                    where v.data_emissao between @DataInicio and @DataFinal
                    group by p.nome, p.id "
                },
                new object[]
                {
                    new FiltroRelatorioVendaProduto
                    {
                        IdCliente = 1,
                        DataInicio = DateTime.Now,
                        DataFinal = DateTime.Now,
                    },
                    @"select p.id as IdProduto, p.nome as NomeProduto, 
                    sum(vp.quantidade) as Quantidade, 
                    sum(vp.preco_bruto * vp.quantidade) as PrecoBrutoTotal, 
                    sum(vp.desconto * vp.quantidade) as DescontoTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) as LucroTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) / sum(vp.preco_bruto * vp.quantidade) * 100 as LucroTotalPorcentagem, 
                    sum(vp.preco_liquido) as PrecoLiquidoTotal, 
                    u.nome as NomeCliente, 
                    u.id as IdCliente 
                    from VendaProduto vp 
                    inner join Produto p on p.id = vp.id_produto 
                    inner join Venda v on v.id = vp.id_venda 
                    inner join Usuario u on u.id = v.id_cliente 
                    where v.data_emissao between @DataInicio and @DataFinal
                    group by p.nome, p.id, u.id, u.nome 
                    having u.id = @IdCliente "
                },
                new object[]
                {
                    new FiltroRelatorioVendaProduto
                    {
                        IdProduto = 1,
                        DataInicio = DateTime.Now,
                        DataFinal = DateTime.Now,
                    },
                    @"select p.id as IdProduto, p.nome as NomeProduto, 
                    sum(vp.quantidade) as Quantidade, 
                    sum(vp.preco_bruto * vp.quantidade) as PrecoBrutoTotal, 
                    sum(vp.desconto * vp.quantidade) as DescontoTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) as LucroTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) / sum(vp.preco_bruto * vp.quantidade) * 100 as LucroTotalPorcentagem, 
                    sum(vp.preco_liquido) as PrecoLiquidoTotal 
                    from VendaProduto vp 
                    inner join Produto p on p.id = vp.id_produto 
                    inner join Venda v on v.id = vp.id_venda 
                    where v.data_emissao between @DataInicio and @DataFinal
                    group by p.nome, p.id 
                    having p.id = @IdProduto "
                },
                new object[]
                {
                    new FiltroRelatorioVendaProduto
                    {
                        IdCliente = 1,
                        IdProduto = 1,
                        DataInicio = DateTime.Now,
                        DataFinal = DateTime.Now,
                    },
                    @"select p.id as IdProduto, p.nome as NomeProduto, 
                    sum(vp.quantidade) as Quantidade, 
                    sum(vp.preco_bruto * vp.quantidade) as PrecoBrutoTotal, 
                    sum(vp.desconto * vp.quantidade) as DescontoTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) as LucroTotal, 
                    sum(vp.preco_liquido - vp.preco_bruto * vp.quantidade) / sum(vp.preco_bruto * vp.quantidade) * 100 as LucroTotalPorcentagem, 
                    sum(vp.preco_liquido) as PrecoLiquidoTotal, 
                    u.nome as NomeCliente, 
                    u.id as IdCliente 
                    from VendaProduto vp 
                    inner join Produto p on p.id = vp.id_produto 
                    inner join Venda v on v.id = vp.id_venda 
                    inner join Usuario u on u.id = v.id_cliente 
                    where v.data_emissao between @DataInicio and @DataFinal
                    group by p.nome, p.id, u.id, u.nome 
                    having u.id = @IdCliente and p.id = @IdProduto "
                },

            };

    }
}
