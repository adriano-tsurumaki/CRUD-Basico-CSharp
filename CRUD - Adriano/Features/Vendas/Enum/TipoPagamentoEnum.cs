using System.ComponentModel;

namespace CRUD___Adriano.Features.Vendas.Enum
{
    public enum TipoPagamentoEnum
    {
        [Description("Dinheiro")]
        Dinheiro = 1,
        [Description("Débito")]
        Debito = 2,
        [Description("Crédito")]
        Credito = 3,
        [Description("Cheque")]
        Cheque = 4,
    }
}
