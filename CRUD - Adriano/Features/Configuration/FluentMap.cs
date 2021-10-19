using CRUD___Adriano.Features.Cliente.Model;
using CRUD___Adriano.Features.Cliente.Dao;
using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;

namespace CRUD___Adriano.Features
{
    public static class FluentMap
    {
        public static void InicializarMap() =>
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new UsuarioMap());
                config.AddMap(new ClienteMap());
                config.ForDommel();
            });
    }
}
