using Dapper.FluentMap.Dommel.Mapping;
using Dapper.FluentMap.Mapping;

namespace CRUD___Adriano.Features.Usuario.Model
{
    public class UsuarioMap : DommelEntityMap<UsuarioModel>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");
            Map(x => x.IdUsuario).ToColumn("id", caseSensitive: false).IsKey();
            Map(x => x.Nome).ToColumn("nome", caseSensitive: false);
            Map(x => x.Sobrenome).ToColumn("sobrenome", caseSensitive: false);
            Map(x => x.Sexo).ToColumn("sexo", caseSensitive: false);
            Map(x => x.DataNascimento).ToColumn("data_nascimento", caseSensitive: false);
        }
    }
}
