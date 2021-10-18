using CRUD___Adriano.Features.Cadastro.Produto.Model;
using Dapper.FluentMap.Mapping;

namespace CRUD___Adriano.Features.Produto.Dao
{
    internal class ClienteMap: EntityMap<ClienteModel>
    {
        public ClienteMap()
        {
            Map(x => x.Id).ToColumn("id", caseSensitive: false);
        }
    }
}
