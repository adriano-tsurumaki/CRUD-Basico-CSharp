using CRUD___Adriano.Features.Vendas.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Teste_Unitário.Model
{
    [TestClass]
    public class VendaProdutoModelDeveria
    {
        [DataTestMethod]
        [DynamicData(nameof(Lista_para_comparar_duas_vendas), DynamicDataSourceType.Method)]
        public void Deveria_comparar_vendas_corretamente_com_o_operador_de_igualdade(VendaProdutoModel vendaProdutoA, VendaProdutoModel vendaProdutoB, bool resultadoEsperado) =>
            Assert.AreEqual(resultadoEsperado, vendaProdutoA == vendaProdutoB);

        [DataTestMethod]
        [DynamicData(nameof(Lista_para_comparar_duas_vendas), DynamicDataSourceType.Method)]
        public void Deveria_comparar_vendas_corretamente_com_o_operador_de_desigualdade(VendaProdutoModel vendaProdutoA, VendaProdutoModel vendaProdutoB, bool resultadoEsperado) =>
            Assert.AreEqual(!resultadoEsperado, vendaProdutoA != vendaProdutoB);

        public static IEnumerable<object[]> Lista_para_comparar_duas_vendas() =>
            new List<object[]>
            {
                new object[]
                {
                    new VendaProdutoModel 
                    { 
                        Id = 1,
                        IdProduto = 1,
                        IdVenda = 1,
                        Lucro = 2.00,
                        Desconto = 5.75,
                        Nome = "Produto X",
                        PrecoBruto = 12.00,
                        Quantidade = 5
                    },
                    new VendaProdutoModel
                    {
                        Id = 1,
                        IdProduto = 1,
                        IdVenda = 1,
                        Lucro = 2.00,
                        Desconto = 5.75,
                        Nome = "Produto X",
                        PrecoBruto = 12.00,
                        Quantidade = 5
                    },
                    true
                },
                new object[]
                {
                    new VendaProdutoModel
                    {
                        Id = 1,
                        IdProduto = 1,
                        IdVenda = 1,
                        Lucro = 2.00,
                        Desconto = 5.75,
                        Nome = "Produto X",
                        PrecoBruto = 12.00,
                        Quantidade = 5
                    },
                    new VendaProdutoModel
                    {
                        Id = 2,
                        IdProduto = 1,
                        IdVenda = 1,
                        Lucro = 2.00,
                        Desconto = 5.75,
                        Nome = "Produto X",
                        PrecoBruto = 12.00,
                        Quantidade = 5
                    },
                    false
                },
                new object[]
                {
                    new VendaProdutoModel
                    {
                        Id = 1,
                        IdProduto = 1,
                        IdVenda = 1,
                        Lucro = 2.00,
                        Desconto = 5.75,
                        Nome = "Produto X",
                        PrecoBruto = 12.00,
                        Quantidade = 5
                    },
                    new VendaProdutoModel
                    {
                        Id = 1,
                        IdProduto = 1,
                        IdVenda = 2,
                        Lucro = 2.00,
                        Desconto = 5.75,
                        Nome = "Produto X",
                        PrecoBruto = 12.00,
                        Quantidade = 5
                    },
                    false
                },
                new object[]
                {
                    new VendaProdutoModel
                    {
                        Id = 1,
                        IdProduto = 1,
                        IdVenda = 1,
                        Lucro = 2.00,
                        Desconto = 5.75,
                        Nome = "Produto X",
                        PrecoBruto = 12.00,
                        Quantidade = 5
                    },
                    new VendaProdutoModel
                    {
                        Id = 1,
                        IdProduto = 1,
                        IdVenda = 1,
                        Lucro = 3.00,
                        Desconto = 5.75,
                        Nome = "Produto X",
                        PrecoBruto = 12.00,
                        Quantidade = 5
                    },
                    false
                },
                new object[]
                {
                    new VendaProdutoModel
                    {
                        Id = 1,
                        IdProduto = 1,
                        IdVenda = 1,
                        Lucro = 2.00,
                        Desconto = 5.75,
                        Nome = "Produto X",
                        PrecoBruto = 12.00,
                        Quantidade = 5
                    },
                    new VendaProdutoModel
                    {
                        Id = 1,
                        IdProduto = 1,
                        IdVenda = 1,
                        Lucro = 2.00,
                        Desconto = 6.75,
                        Nome = "Produto X",
                        PrecoBruto = 12.00,
                        Quantidade = 5
                    },
                    false
                },
                new object[]
                {
                    new VendaProdutoModel
                    {
                        Id = 1,
                        IdProduto = 1,
                        IdVenda = 1,
                        Lucro = 2.00,
                        Desconto = 5.75,
                        Nome = "Produto X",
                        PrecoBruto = 12.00,
                        Quantidade = 5
                    },
                    new VendaProdutoModel
                    {
                        Id = 1,
                        IdProduto = 1,
                        IdVenda = 1,
                        Lucro = 2.00,
                        Desconto = 5.75,
                        Nome = "Produto Y",
                        PrecoBruto = 12.00,
                        Quantidade = 5
                    },
                    false
                },
                new object[]
                {
                    new VendaProdutoModel
                    {
                        Id = 1,
                        IdProduto = 1,
                        IdVenda = 1,
                        Lucro = 2.00,
                        Desconto = 5.75,
                        Nome = "Produto X",
                        PrecoBruto = 12.00,
                        Quantidade = 5
                    },
                    new VendaProdutoModel
                    {
                        Id = 1,
                        IdProduto = 1,
                        IdVenda = 1,
                        Lucro = 2.00,
                        Desconto = 5.75,
                        Nome = "Produto X",
                        PrecoBruto = 12.00,
                        Quantidade = 6
                    },
                    false
                },
            };
    }
}
