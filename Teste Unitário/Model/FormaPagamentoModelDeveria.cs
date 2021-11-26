using CRUD___Adriano.Features.Vendas.Enum;
using CRUD___Adriano.Features.Vendas.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Teste_Unitário.Model
{
    [TestClass]
    public class FormaPagamentoModelDeveria
    {
        [DataTestMethod]
        [DynamicData(nameof(Lista_para_comparar_dois_pagamentos), DynamicDataSourceType.Method)]
        public void Deveria_comparar_pagamentos_corretamente_com_o_operador_de_igualdade(FormaPagamentoModel formaPagamentoA, FormaPagamentoModel formaPagamentoB, bool resultadoEsperado) =>
           Assert.AreEqual(resultadoEsperado, formaPagamentoA == formaPagamentoB);

        [DataTestMethod]
        [DynamicData(nameof(Lista_para_comparar_dois_pagamentos), DynamicDataSourceType.Method)]
        public void Deveria_comparar_pagamentos_corretamente_com_o_operador_de_desigualdade(FormaPagamentoModel formaPagamentoA, FormaPagamentoModel formaPagamentoB, bool resultadoEsperado) =>
            Assert.AreEqual(!resultadoEsperado, formaPagamentoA != formaPagamentoB);

        public static IEnumerable<object[]> Lista_para_comparar_dois_pagamentos() =>
            new List<object[]>
            {
                new object[]
                {
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 1,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "1",
                        OrdemPagamento = 1
                    },
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 1,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "1",
                        OrdemPagamento = 1
                    },
                    true
                },
                new object[]
                {
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 1,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "1",
                        OrdemPagamento = 1
                    },
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 0,
                        PosicaoPagamento = 1,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "1",
                        OrdemPagamento = 1
                    },
                    false
                },
                new object[]
                {
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 1,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "1",
                        OrdemPagamento = 1
                    },
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 0,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "1",
                        OrdemPagamento = 1
                    },
                    false
                },
                new object[]
                {
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 1,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "1",
                        OrdemPagamento = 1
                    },
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 1,
                        ValorAPagar = 101,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "1",
                        OrdemPagamento = 1
                    },
                    false
                },
                new object[]
                {
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 1,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "1",
                        OrdemPagamento = 1
                    },
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 1,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Credito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "1",
                        OrdemPagamento = 1
                    },
                    false
                },
                new object[]
                {
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 1,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "1",
                        OrdemPagamento = 1
                    },
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 1,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 1,
                        PosicaoParcela = "1",
                        OrdemPagamento = 1
                    },
                    false
                },
                new object[]
                {
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 1,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "1",
                        OrdemPagamento = 1
                    },
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 1,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "2",
                        OrdemPagamento = 1
                    },
                    false
                },
                new object[]
                {
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 1,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "1",
                        OrdemPagamento = 1
                    },
                    new FormaPagamentoModel
                    {
                        Id = 1,
                        IdVenda = 1,
                        PosicaoPagamento = 1,
                        ValorAPagar = 100,
                        TipoPagamento = TipoPagamentoEnum.Debito,
                        QuantidadeParcelas = 0,
                        PosicaoParcela = "1",
                        OrdemPagamento = 2
                    },
                    false
                },
            };
    }
}
