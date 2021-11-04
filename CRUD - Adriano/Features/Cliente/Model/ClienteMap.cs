using CRUD___Adriano.Features.Cadastro.Produto.Model;
using Dapper.FluentMap.Dommel.Mapping;

namespace CRUD___Adriano.Features.Cliente.Model
{
    public class ClienteMap : DommelEntityMap<ClienteModel>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            Map(x => x.Id).ToColumn("id", caseSensitive: false).IsKey();
            Map(x => x.ValorLimite).ToColumn("valor_limite", caseSensitive: false);
        }
    }
}
