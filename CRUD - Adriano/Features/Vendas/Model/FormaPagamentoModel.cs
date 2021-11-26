using CRUD___Adriano.Features.ValueObject.Precos;
using CRUD___Adriano.Features.Vendas.Enum;

namespace CRUD___Adriano.Features.Vendas.Model
{
    public class FormaPagamentoModel
    {
        public int Id { get; set; }
        public int IdVenda { get; set; }
        public int PosicaoPagamento { get; set; }
        public Preco ValorAPagar { get; set; }
        public TipoPagamentoEnum TipoPagamento { get; set; }
        public int QuantidadeParcelas { get; set; }
        public string PosicaoParcela { get; set; }
        public int OrdemPagamento { get; set; }

        public static bool operator ==(FormaPagamentoModel pagamentoModelA, FormaPagamentoModel pagamentoModelB) =>
            pagamentoModelA.Id == pagamentoModelB.Id && pagamentoModelA.IdVenda == pagamentoModelB.IdVenda &&
            pagamentoModelA.PosicaoPagamento == pagamentoModelB.PosicaoPagamento && pagamentoModelA.ValorAPagar == pagamentoModelB.ValorAPagar &&
            pagamentoModelA.TipoPagamento == pagamentoModelB.TipoPagamento && pagamentoModelA.QuantidadeParcelas == pagamentoModelB.QuantidadeParcelas &&
            pagamentoModelA.PosicaoParcela == pagamentoModelB.PosicaoParcela && pagamentoModelA.OrdemPagamento == pagamentoModelB.OrdemPagamento;

        public static bool operator !=(FormaPagamentoModel pagamentoModelA, FormaPagamentoModel pagamentoModelB) =>
            pagamentoModelA.Id != pagamentoModelB.Id || pagamentoModelA.IdVenda != pagamentoModelB.IdVenda ||
            pagamentoModelA.PosicaoPagamento != pagamentoModelB.PosicaoPagamento || pagamentoModelA.ValorAPagar != pagamentoModelB.ValorAPagar ||
            pagamentoModelA.TipoPagamento != pagamentoModelB.TipoPagamento || pagamentoModelA.QuantidadeParcelas != pagamentoModelB.QuantidadeParcelas ||
            pagamentoModelA.PosicaoParcela != pagamentoModelB.PosicaoParcela || pagamentoModelA.OrdemPagamento != pagamentoModelB.OrdemPagamento;
    }
}
