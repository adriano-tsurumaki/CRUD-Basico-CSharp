using BuildQuery;
using BuildQuery.Mapping;
using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Entidades.Endereco.Model;
using CRUD___Adriano.Features.Usuario.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste_Unitário.BuildQuery
{
    [TestClass]
    public class BuildQueryDeveria
    {
        [TestMethod]
        public void Teste()
        {
            BuildQueryMapper.Initialize(config =>
            {
                config.AddMap(new UsuarioMap());
                config.AddMap(new ClienteMap());
            });
             
            var query = new BuildQuery<ClienteModel>()
                .Select(c => c.Id)
                .Select(c => c.IdUsuario, "id_usuario")
                .SelectOut<EnderecoModel>(e => e.Bairro)
                .SelectOut<EnderecoModel>(e => e.Numero)
                .InnerJoin<UsuarioModel>(u => u.IdUsuario, e => e.IdUsuario)
                .InnerJoin<EnderecoModel, UsuarioModel>(e => e.IdUsuario, u => u.IdUsuario)
                .Build();
        }
    }

    public class UsuarioMap : EntityMap<UsuarioModel>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");
            Map(x => x.Cpf).ToColumn("cpf");
            Map(x => x.DataNascimento).ToColumn("data_nascimento");
            Map(x => x.Emails).ToColumn("data_nascimento");
        }
    }

    public class ClienteMap : EntityMap<ClienteModel>
    {
        public ClienteMap()
        {
            ToTable("Usuario");
            Map(x => x.Cpf).ToColumn("cpf");
            Map(x => x.DataNascimento).ToColumn("data_nascimento");
            Map(x => x.Emails).ToColumn("data_nascimento");
        }
    }
}
