using BuildQuery.EntityMapping;
using CRUD___Adriano.Features.Colaborador.Model;

namespace CRUD___Adriano.SqlMapper
{
    public class ColaboradorMap : EntityMap<ColaboradorModel>
    {
        public ColaboradorMap()
        {
            ToTable("Colaborador");
            Map(x => x.IdUsuario).ToColumn("id_usuario").IsBaseClass();
            Map(x => x.Id).ToColumn("id");
            Map(x => x.Salario).ToColumn("salario");
            Map(x => x.Comissao).ToColumn("comissao");
        }
    }
}
