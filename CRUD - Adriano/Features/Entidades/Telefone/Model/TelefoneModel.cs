using CRUD___Adriano.Features.Entidades.Telefone.Enum;

namespace CRUD___Adriano.Features.Entidades.Telefone.Model
{
    public class TelefoneModel
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Numero { get; set; }
        public TipoTelefoneEnum Tipo { get; set; }
    }
}
