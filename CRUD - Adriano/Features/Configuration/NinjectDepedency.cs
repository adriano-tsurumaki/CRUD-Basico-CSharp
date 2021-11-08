using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cadastro.Usuario.View;
using CRUD___Adriano.Features.Cliente.Controller;
using CRUD___Adriano.Features.Cliente.View;
using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Interface;
using CRUD___Adriano.Features.Usuario.Controller;
using CRUD___Adriano.Features.Usuario.View;
using Ninject;
using Ninject.Modules;
using System.Data;
using System.Reflection;

namespace CRUD___Adriano.Features.Configuration
{
    public class NinjectDepedency : NinjectModule
    {
        public override void Load()
        {
            Bind<IDbConnection>().ToMethod(ctx => SqlConexao.RetornarConexao());
            
            Bind(typeof(IControllerBase<ClienteModel>)).To(typeof(ClienteController));
            Bind(typeof(IControllerBase<ColaboradorModel>)).To(typeof(ColaboradorModel));

            Bind<UsuarioControllerPage<ClienteModel>>().ToConstructor(ctx => new UsuarioControllerPage<ClienteModel>(new FrmCadastroUsuario<ClienteModel>()));
            Bind<UsuarioControllerPage<ColaboradorModel>>().ToConstructor(ctx => new UsuarioControllerPage<ColaboradorModel>(new FrmCadastroUsuario<ColaboradorModel>()));

            Bind<EmailTelefoneControllerPage<ClienteModel>>().ToConstructor(ctx => new EmailTelefoneControllerPage<ClienteModel>(new FrmEmailTelefone<ClienteModel>()));
            Bind<EmailTelefoneControllerPage<ColaboradorModel>>().ToConstructor(ctx => new EmailTelefoneControllerPage<ColaboradorModel>(new FrmEmailTelefone<ColaboradorModel>()));
        }
    }
}
