using System.ComponentModel;

namespace CRUD___Adriano.Features.Vendas.Sql
{
    public enum ComparadorEnum
    {
        [Description("Igual á")]
        Igual = 1,
        
        [Description("Maior que")]
        Maior = 2,
        
        [Description("Menor que")]
        Menor = 3,

        [Description("Diferente de")]
        Diferente = 4,
    }
}