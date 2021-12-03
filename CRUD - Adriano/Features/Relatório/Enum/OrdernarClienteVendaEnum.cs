using System.ComponentModel;

namespace CRUD___Adriano.Features.Relatório.Enum
{
    public enum OrdernarClienteVendaEnum
    {
        [Description("Cliente")]
        Cliente = 1,

        [Description("Quantidade")]
        Quantidade = 2,

        [Description("Total de desconto")]
        TotalDesconto = 3,

        [Description("Total líquido")]
        TotalLiquido = 4,
    }
}
