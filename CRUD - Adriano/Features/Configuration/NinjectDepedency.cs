using CRUD___Adriano.Features.Factory;
using Ninject.Modules;
using System.Data;

namespace CRUD___Adriano.Features.Configuration
{
    public class NinjectDepedency : NinjectModule
    {
        public override void Load()
        {
            Bind<IDbConnection>().ToMethod(ctx => SqlConexao.RetornarConexao());
            Bind<ControllerConexao>().To<ControllerConexao>();
        }
    }
}
