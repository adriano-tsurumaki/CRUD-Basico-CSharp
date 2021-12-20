using BuildQuery.EntityMapping;
using CRUD___Adriano.Features.Usuario.Model;

namespace CRUD___Adriano.SqlMapper
{
    public class UsuarioMap : EntityMap<UsuarioModel>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");
            Map(x => x.IdUsuario).ToColumn("id");
            Map(x => x.Nome).ToColumn("nome");
            Map(x => x.Sobrenome).ToColumn("sobrenome");
            Map(x => x.Cpf).ToColumn("cpf");
            Map(x => x.Sexo).ToColumn("sexo");
            Map(x => x.DataNascimento).ToColumn("data_nascimento");
        }
    }
}
