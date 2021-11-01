using System.ComponentModel;

namespace CRUD___Adriano.Features.Entidades.Telefone.Enum
{
    public enum TipoTelefoneEnum
    {
        [Description("Comercial")]
        Comercial = 1,
        [Description("Fixo")]
        Fixo = 2,
        [Description("Celular")]
        Celular = 3
    }
}
