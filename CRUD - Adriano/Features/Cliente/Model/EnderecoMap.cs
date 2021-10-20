using Dapper.FluentMap.Mapping;

namespace CRUD___Adriano.Features.Cliente.Model
{
    public class EnderecoMap : EntityMap<EnderecoModel>
    {
        public EnderecoMap()
        {
            Map(x => x.Cep).ToColumn("cep", caseSensitive: false);
            Map(x => x.Logradouro).ToColumn("logradouro", caseSensitive: false);
            Map(x => x.Bairro).ToColumn("bairro", caseSensitive: false);
            Map(x => x.Complemento).ToColumn("complemento", caseSensitive: false);
            Map(x => x.Cidade).ToColumn("cidade", caseSensitive: false);
            Map(x => x.Uf).ToColumn("uf", caseSensitive: false);
            Map(x => x.Numero).ToColumn("numero", caseSensitive: false);
        }
    }
}
