using CRUD___Adriano.Features.ValueObject.Precos;
using CRUD___Adriano.Features.Vendas.Enum;

namespace CRUD___Adriano.Features.Vendas.Model
{
    public class FormaPagamentoModel
    {
        public int IdVenda { get; set; }
        public int PosicaoPagamento { get; set; }
        public Preco ValorAPagar { get; set; }
        public TipoPagamentoEnum TipoPagamento { get; set; }
        public int QuantidadeParcelas { get; set; }
        public string PosicaoParcela { get; set; }
    }
}
