using CRUD___Adriano.Features.Atalhos.Controller;
using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cadastro.Usuario.View;
using CRUD___Adriano.Features.Cliente.Controller;
using CRUD___Adriano.Features.Cliente.Dao;
using CRUD___Adriano.Features.Cliente.View;
using CRUD___Adriano.Features.Colaborador.Controller;
using CRUD___Adriano.Features.Colaborador.Dao;
using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.Colaborador.View;
using CRUD___Adriano.Features.Configuration;
using CRUD___Adriano.Features.Configuration.Login.Controller;
using CRUD___Adriano.Features.Configuration.Login.Dao;
using CRUD___Adriano.Features.Configuration.Login.View;
using CRUD___Adriano.Features.Dashboards.Controller;
using CRUD___Adriano.Features.Dashboards.View;
using CRUD___Adriano.Features.Factory;
using CRUD___Adriano.Features.Fornecedor.Controller;
using CRUD___Adriano.Features.Fornecedor.Dao;
using CRUD___Adriano.Features.Fornecedor.Model;
using CRUD___Adriano.Features.Fornecedor.View;
using CRUD___Adriano.Features.Produto.Controller;
using CRUD___Adriano.Features.Produto.Dao;
using CRUD___Adriano.Features.Produto.View;
using CRUD___Adriano.Features.Usuario.Controller;
using CRUD___Adriano.Features.Usuario.View;
using Ninject;
using System.Data;

namespace CRUD___Adriano.Features.IoC
{
    public class ConfigNinject
    {
        public static StandardKernel kernel = new StandardKernel();

        public static StandardKernel Registrar(SqlConexao connectionString)
        {
            kernel = new StandardKernel(
                new NinjectSettings
                {
                    AllowNullInjection = true
                });

            //Interfaces
            kernel.Bind(typeof(IControllerBase<ClienteModel>)).To<ClienteController>();
            kernel.Bind(typeof(IControllerBase<ColaboradorModel>)).To<ColaboradorModel>();
            kernel.Bind(typeof(IControllerBase<FornecedorModel>)).To<FornecedorModel>();

            kernel.Bind(typeof(IControllerListarIdNome<ClienteModel>)).To<ClienteController>();
            kernel.Bind(typeof(IControllerListarIdNome<ColaboradorModel>)).To<ColaboradorController>();
            kernel.Bind(typeof(IControllerListarIdNome<FornecedorModel>)).To<FornecedorController>();

            //Database
            kernel.Bind<SqlConexao>().ToConstant(connectionString);

            //Controllers
            kernel.Bind<LoginController>().ToSelf();
            kernel.Bind<DashboardController>().ToSelf();
            kernel.Bind<AtalhoController>().ToSelf();
            kernel.Bind<ClienteController>().ToSelf();
            kernel.Bind<ClienteControllerPage>().ToSelf();
            kernel.Bind<ClienteListagemController>().ToSelf();
            kernel.Bind<ColaboradorController>().ToSelf();
            kernel.Bind<ColaboradorControllerPage>().ToSelf();
            kernel.Bind<ColaboradorListagemController>().ToSelf();
            kernel.Bind<FornecedorController>().ToSelf();
            kernel.Bind<FornecedorControllerPage>().ToSelf();
            kernel.Bind<ProdutoController>().ToSelf();
            kernel.Bind<ProdutoControllerPage>().ToSelf();
            kernel.Bind<UsuarioControllerPage<ClienteModel>>().ToConstructor(ctx => new UsuarioControllerPage<ClienteModel>(new FrmCadastroUsuario<ClienteModel>()));
            kernel.Bind<UsuarioControllerPage<ColaboradorModel>>().ToConstructor(ctx => new UsuarioControllerPage<ColaboradorModel>(new FrmCadastroUsuario<ColaboradorModel>()));
            kernel.Bind<UsuarioControllerPage<FornecedorModel>>().ToConstructor(ctx => new UsuarioControllerPage<FornecedorModel>(new FrmCadastroUsuario<FornecedorModel>()));
            kernel.Bind<EmailTelefoneControllerPage<ClienteModel>>().ToConstructor(ctx => new EmailTelefoneControllerPage<ClienteModel>(new FrmEmailTelefone<ClienteModel>()));
            kernel.Bind<EmailTelefoneControllerPage<ColaboradorModel>>().ToConstructor(ctx => new EmailTelefoneControllerPage<ColaboradorModel>(new FrmEmailTelefone<ColaboradorModel>()));
            kernel.Bind<EmailTelefoneControllerPage<FornecedorModel>>().ToConstructor(ctx => new EmailTelefoneControllerPage<FornecedorModel>(new FrmEmailTelefone<FornecedorModel>()));

            //DAOs
            kernel.Bind<LoginDao>().ToSelf();
            kernel.Bind<ClienteDao>().ToSelf();
            kernel.Bind<ColaboradorDao>().ToSelf();
            kernel.Bind<FornecedorDao>().ToSelf();
            kernel.Bind<ProdutoDao>().ToSelf();

            //Views
            kernel.Bind<FrmLogin>().ToSelf();
            kernel.Bind<FrmDashboard>().ToSelf();
            kernel.Bind<FrmAtalhos>().ToSelf();
            kernel.Bind<FrmCadastroCliente>().ToSelf();
            kernel.Bind<FrmDetalhesCliente>().ToSelf();
            kernel.Bind<FrmListagemCliente>().ToSelf();
            kernel.Bind<FrmCadastroColaborador>().ToSelf();
            kernel.Bind<FrmDetalhesColaborador>().ToSelf();
            kernel.Bind<FrmListagemColaborador>().ToSelf();
            kernel.Bind<FrmCadastroFornecedor>().ToSelf();
            kernel.Bind<FrmCadastroProduto>().ToSelf();
            kernel.Bind<FrmPrincipal>().ToSelf();

            kernel.Bind<IDbConnection>().ToMethod(ctx => SqlConexao.RetornarConexao());

            return kernel;
        }

        public static T ObterInstancia<T>()
        {
            return kernel.Get<T>();
        }
    }
}
