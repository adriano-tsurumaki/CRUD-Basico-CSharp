using System.ComponentModel;

namespace CRUD___Adriano.Features.Colaborador.Enum
{
    public enum TipoContaEnum
    {
        [Description("Conta Poupança")]
        Poupanca = 1,
        
        [Description("Conta Corrente")]
        Corrente = 2,
        
        [Description("Conta Universitário")]
        Universitario = 3
    }
}
