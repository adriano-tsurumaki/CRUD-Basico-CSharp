﻿using CRUD___Adriano.Features.Atalhos.Controller;
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
using CRUD___Adriano.Features.Factory;
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
            kernel.Bind(typeof(IControllerBase<ColaboradorModel>)).To(typeof(ColaboradorModel));

            //Database
            kernel.Bind<SqlConexao>().ToConstant(connectionString);

            //Controllers
            kernel.Bind<AtalhoController>().ToSelf();
            kernel.Bind<ClienteController>().ToSelf();
            kernel.Bind<ClienteControllerPage>().ToSelf();
            kernel.Bind<ClienteListagemController>().ToSelf();
            kernel.Bind<ColaboradorController>().ToSelf();
            kernel.Bind<ColaboradorControllerPage>().ToSelf();
            kernel.Bind<ColaboradorListagemController>().ToSelf();
            kernel.Bind<UsuarioControllerPage<ClienteModel>>().ToConstructor(ctx => new UsuarioControllerPage<ClienteModel>(new FrmCadastroUsuario<ClienteModel>()));
            kernel.Bind<UsuarioControllerPage<ColaboradorModel>>().ToConstructor(ctx => new UsuarioControllerPage<ColaboradorModel>(new FrmCadastroUsuario<ColaboradorModel>()));
            kernel.Bind<EmailTelefoneControllerPage<ClienteModel>>().ToConstructor(ctx => new EmailTelefoneControllerPage<ClienteModel>(new FrmEmailTelefone<ClienteModel>()));
            kernel.Bind<EmailTelefoneControllerPage<ColaboradorModel>>().ToConstructor(ctx => new EmailTelefoneControllerPage<ColaboradorModel>(new FrmEmailTelefone<ColaboradorModel>()));

            //DAOs
            kernel.Bind<ClienteDao>().ToSelf();
            kernel.Bind<ColaboradorDao>().ToSelf();

            //Views
            kernel.Bind<FrmAtalhos>().ToSelf();
            kernel.Bind<FrmCadastroCliente>().ToSelf();
            kernel.Bind<FrmDetalhesCliente>().ToSelf();
            kernel.Bind<FrmListagemCliente>().ToSelf();
            kernel.Bind<FrmCadastroColaborador>().ToSelf();
            kernel.Bind<FrmDetalhesColaborador>().ToSelf();
            kernel.Bind<FrmListagemColaborador>().ToSelf();
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