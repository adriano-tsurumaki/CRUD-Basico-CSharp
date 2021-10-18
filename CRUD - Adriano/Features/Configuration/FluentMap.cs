using CRUD___Adriano.Features.Produto.Dao;
using Dapper.FluentMap;

namespace CRUD___Adriano.Features
{
    public static class FluentMap
    {
        public static void InicializarMap() =>
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new ClienteMap());
            });
    }
}
