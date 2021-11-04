using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.Controller;
using CRUD___Adriano.Features.Colaborador.Model;
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
            Bind(typeof(IControllerBase<ClienteModel>)).To(typeof(ClienteController));
            Bind(typeof(IControllerBase<ColaboradorModel>)).To(typeof(ColaboradorModel));
        }
    }
}
