using CRUD___Adriano.Features.Vendas.Controller;
using CRUD___Adriano.Features.Vendas.Enum;
using CRUD___Adriano.Features.Vendas.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Teste_Unitário.Vendas
{
    [TestClass]
    public class FormaPagamentoControllerDeveria
    {
        [DataTestMethod]
        [DynamicData(nameof(Lista_para_comparar_duas_listas_de_pagamento), DynamicDataSourceType.Method)]
        public void Deveria_gerar_lista_de_pagamentos_corretamente(
            int quantidadeParcelas, TipoPagamentoEnum tipoPagamento, double valorASerPago,
            IList<FormaPagamentoModel> listaFormaPagamentoEsperado)
        {
            var listaFormaPagamento = FormaPagamentoController.GerarListaFormaPagamento(quantidadeParcelas, tipoPagamento, valorASerPago);

            Assert.AreEqual(listaFormaPagamento.Count, listaFormaPagamentoEsperado.Count);

            for (int i = 0; i < listaFormaPagamento.Count; i++)
                Assert.IsTrue(listaFormaPagamento[i] == listaFormaPagamentoEsperado[i]);
        }

        public static IEnumerable<object[]> Lista_para_comparar_duas_listas_de_pagamento() =>
            new List<object[]>
            {
                new object[]
                {
                    0,
                    TipoPagamentoEnum.Dinheiro,
                    100.75,
                    new List<FormaPagamentoModel>
                    {
                        new FormaPagamentoModel
                        {
                            QuantidadeParcelas = 0,
                            TipoPagamento = TipoPagamentoEnum.Dinheiro,
                            ValorAPagar = 100.75,
                            PosicaoParcela = "0",
                        }
                    }
                },
                new object[]
                {
                    1,
                    TipoPagamentoEnum.Debito,
                    100,
                    new List<FormaPagamentoModel>
                    {
                        new FormaPagamentoModel
                        {
                            QuantidadeParcelas = 1,
                            TipoPagamento = TipoPagamentoEnum.Debito,
                            ValorAPagar = 100,
                            PosicaoParcela = "1/1",
                        }
                    }
                },
                new object[]
                {
                    3,
                    TipoPagamentoEnum.Credito,
                    100,
                    new List<FormaPagamentoModel>
                    {
                        new FormaPagamentoModel
                        {
                            QuantidadeParcelas = 3,
                            TipoPagamento = TipoPagamentoEnum.Credito,
                            ValorAPagar = 33.33,
                            PosicaoParcela = "1/3",
                        },
                        new FormaPagamentoModel
                        {
                            QuantidadeParcelas = 3,
                            TipoPagamento = TipoPagamentoEnum.Credito,
                            ValorAPagar = 33.33,
                            PosicaoParcela = "2/3",
                        },
                        new FormaPagamentoModel
                        {
                            QuantidadeParcelas = 3,
                            TipoPagamento = TipoPagamentoEnum.Credito,
                            ValorAPagar = 33.34,
                            PosicaoParcela = "3/3",
                        },
                    }
                },
                new object[]
                {
                    6,
                    TipoPagamentoEnum.Cheque,
                    1565.25,
                    new List<FormaPagamentoModel>
                    {
                        new FormaPagamentoModel
                        {
                            QuantidadeParcelas = 6,
                            TipoPagamento = TipoPagamentoEnum.Cheque,
                            ValorAPagar = 260.88,
                            PosicaoParcela = "1/6",
                        },
                        new FormaPagamentoModel
                        {
                            QuantidadeParcelas = 6,
                            TipoPagamento = TipoPagamentoEnum.Cheque,
                            ValorAPagar = 260.88,
                            PosicaoParcela = "2/6",
                        },
                        new FormaPagamentoModel
                        {
                            QuantidadeParcelas = 6,
                            TipoPagamento = TipoPagamentoEnum.Cheque,
                            ValorAPagar = 260.88,
                            PosicaoParcela = "3/6",
                        },
                        new FormaPagamentoModel
                        {
                            QuantidadeParcelas = 6,
                            TipoPagamento = TipoPagamentoEnum.Cheque,
                            ValorAPagar = 260.88,
                            PosicaoParcela = "4/6",
                        },
                        new FormaPagamentoModel
                        {
                            QuantidadeParcelas = 6,
                            TipoPagamento = TipoPagamentoEnum.Cheque,
                            ValorAPagar = 260.88,
                            PosicaoParcela = "5/6",
                        },
                        new FormaPagamentoModel
                        {
                            QuantidadeParcelas = 6,
                            TipoPagamento = TipoPagamentoEnum.Cheque,
                            ValorAPagar = 260.85,
                            PosicaoParcela = "6/6",
                        }
                    }
                },
            };
    }
}
