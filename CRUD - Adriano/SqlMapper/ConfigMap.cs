using BuildQuery;

namespace CRUD___Adriano.SqlMapper
{
    public class ConfigMap
    {
        public static void InicializarMap() =>
            BuildQueryMapper.Initialize(config =>
            {
                config.AddMap(new UsuarioMap());
                config.AddMap(new ClienteMap());
                config.AddMap(new ColaboradorMap());
                config.AddMap(new EnderecoMap());
                config.AddMap(new TelefoneMap());
                config.AddMap(new EmailMap());
            });
    }
}
