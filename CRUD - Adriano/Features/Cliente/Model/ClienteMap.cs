using CRUD___Adriano.Features.Cadastro.Produto.Model;
using Dapper.FluentMap.Mapping;

namespace CRUD___Adriano.Features.Cliente.Dao
{
    public class ClienteMap : EntityMap<ClienteModel>
    {
        public ClienteMap()
        {
            Map(x => x.Id).ToColumn("id", caseSensitive: false);
            Map(x => x.ValorLimite).ToColumn("valor_limite", caseSensitive: false);
        }
    }
}
