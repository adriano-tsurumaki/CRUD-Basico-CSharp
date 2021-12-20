using BuildQuery.EntityMapping;
using CRUD___Adriano.Features.Entidades.Endereco.Model;

namespace CRUD___Adriano.SqlMapper
{
    public class EnderecoMap : EntityMap<EnderecoModel>
    {
        public EnderecoMap()
        {
            ToTable("Endereco");
            Map(x => x.IdUsuario).ToColumn("id_usuario");
            Map(x => x.Id).ToColumn("id");
            Map(x => x.Cep).ToColumn("cep");
            Map(x => x.Logradouro).ToColumn("logradouro");
            Map(x => x.Bairro).ToColumn("bairro");
            Map(x => x.Complemento).ToColumn("complemento");
            Map(x => x.Cidade).ToColumn("cidade");
            Map(x => x.Uf).ToColumn("uf");
            Map(x => x.Numero).ToColumn("numero");
        }
    }
}
