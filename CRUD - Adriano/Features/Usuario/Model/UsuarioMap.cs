using Dapper.FluentMap.Mapping;

namespace CRUD___Adriano.Features.Usuario.Model
{
    public class UsuarioMap : EntityMap<UsuarioModel>
    {
        public UsuarioMap()
        {
            Map(x => x.Id).ToColumn("id", caseSensitive: false);
            Map(x => x.Nome).ToColumn("nome", caseSensitive: false);
            Map(x => x.Sobrenome).ToColumn("sobrenome", caseSensitive: false);
            Map(x => x.Sexo).ToColumn("sexo", caseSensitive: false);
            Map(x => x.DataNascimento).ToColumn("data_nascimento", caseSensitive: false);
        }
    }
}
