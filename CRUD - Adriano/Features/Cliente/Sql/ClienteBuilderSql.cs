using BuildQuery;
using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Usuario.Model;

namespace CRUD___Adriano.Features.Cliente.Sql
{
    public class ClienteBuilderSql
    {
        public static string ListarTodosComCamposSomenteIdENome() =>
            new BuildQuery<ClienteModel>()
            .Select<UsuarioModel>(u => u.IdUsuario, u => u.Nome)
            .InnerJoin<UsuarioModel>(u => u.IdUsuario, c => c.IdUsuario)
            .Build();
    }
}
