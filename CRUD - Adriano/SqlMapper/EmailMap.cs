using BuildQuery.EntityMapping;
using CRUD___Adriano.Features.Entidades.Email.Model;

namespace CRUD___Adriano.SqlMapper
{
    public class EmailMap : EntityMap<EmailModel>
    {
        public EmailMap()
        {
            ToTable("Email");
            Map(x => x.Id).ToColumn("id_usuario");
            Map(x => x.IdUsuario).ToColumn("id");
            Map(x => x.Nome).ToColumn("nome");
        }
    }
}
