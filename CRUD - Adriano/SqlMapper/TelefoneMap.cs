using BuildQuery.EntityMapping;
using CRUD___Adriano.Features.Entidades.Telefone.Model;

namespace CRUD___Adriano.SqlMapper
{
    public class TelefoneMap : EntityMap<TelefoneModel>
    {
        public TelefoneMap()
        {
            ToTable("Telefone");
            Map(x => x.IdUsuario).ToColumn("id_usuario");
            Map(x => x.Id).ToColumn("id");
            Map(x => x.Numero).ToColumn("numero");
            Map(x => x.Tipo).ToColumn("tipo");
        }
    }
}
