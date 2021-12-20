using BuildQuery.EntityMapping;
using CRUD___Adriano.Features.Cadastro.Produto.Model;

namespace CRUD___Adriano.SqlMapper
{
    public class ClienteMap : EntityMap<ClienteModel>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            Map(x => x.IdUsuario).ToColumn("id_usuario").IsBaseClass();
            Map(x => x.Id).ToColumn("id");
            Map(x => x.ValorLimite).ToColumn("valor_limite");
            Map(x => x.Observacao).ToColumn("observacao");
        }
    }
}
