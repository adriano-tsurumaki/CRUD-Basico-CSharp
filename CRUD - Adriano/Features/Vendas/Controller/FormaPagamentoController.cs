using CRUD___Adriano.Features.ValueObject.Precos;
using CRUD___Adriano.Features.Vendas.Enum;
using CRUD___Adriano.Features.Vendas.Model;
using CRUD___Adriano.Features.Vendas.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD___Adriano.Features.Vendas.Controller
{
    public class FormaPagamentoController
    {
        private readonly UcFormaPagamento _ucFormaPagamento;

        public FormaPagamentoController()
        {
            _ucFormaPagamento = new UcFormaPagamento();
        }

        public void AdicionarModel(VendaModel vendaModel) =>
            _ucFormaPagamento.BindModel(vendaModel);

        public UcFormaPagamento RetornarUserControl() => _ucFormaPagamento;

        public void AtualizarValoresTotais(VendaModel vendaModel) =>
            _ucFormaPagamento.AtualizarValoresTotais(vendaModel);

        public static List<FormaPagamentoModel> GerarListaFormaPagamento(int quantidadeParcelas,
            TipoPagamentoEnum tipoPagamento, double valorASerPago)
        {
            var listaFormaPagamento = new List<FormaPagamentoModel>();

            if (quantidadeParcelas == 0)
            {
                listaFormaPagamento.Add(new FormaPagamentoModel
                {
                    QuantidadeParcelas = quantidadeParcelas,
                    TipoPagamento = tipoPagamento,
                    ValorAPagar = valorASerPago,
                    PosicaoParcela = "0",
                });
            }
            else
            {
                for (var posicao = 1; posicao <= quantidadeParcelas; posicao++)
                {
                    var posicaoParcela = $"{posicao}/{quantidadeParcelas}";
                    Preco valorParcelado = valorASerPago / quantidadeParcelas;
                    listaFormaPagamento.Add(new FormaPagamentoModel
                    {
                        QuantidadeParcelas = quantidadeParcelas,
                        TipoPagamento = tipoPagamento,
                        ValorAPagar = valorParcelado,
                        PosicaoParcela = posicaoParcela,
                    });
                }
                Preco valorSerPago = listaFormaPagamento.Sum(x => x.ValorAPagar.Valor);
                Preco valorTotal = valorASerPago;
                Preco diferencaDeConversao = valorTotal - valorSerPago;

                listaFormaPagamento.Last().ValorAPagar += diferencaDeConversao;

            }
            return listaFormaPagamento;
        }
    }
}
