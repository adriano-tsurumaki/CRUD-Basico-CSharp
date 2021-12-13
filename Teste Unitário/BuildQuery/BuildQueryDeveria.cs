using BuildQuery;
using BuildQuery.EntityMapping;
using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Entidades.Endereco.Model;
using CRUD___Adriano.Features.Usuario.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

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
                config.AddMap(new EnderecoMap());
            });
             
            var query = new BuildQuery<ClienteModel>()
                .Select(c => c.ValorLimite)
                .Select("id_lokao, observacao_lokao", c => c.Id, c => c.Observacao)
                .Select<UsuarioModel>(u => u.IdUsuario, u => u.Nome, u => u.Sobrenome)
                .Select<UsuarioModel>(u => u.Sexo, u => u.Cpf, u => u.DataNascimento)
                .Select<EnderecoModel>(e => e.IdUsuario, e => e.Logradouro, e => e.Cep, e => e.Bairro)
                .Select<EnderecoModel>(e => e.Cidade, e => e.Uf, e => e.Complemento, e => e.Numero)
                .InnerJoin<UsuarioModel>(u => u.IdUsuario, e => e.IdUsuario)
                .InnerJoin<EnderecoModel, UsuarioModel>(e => e.IdUsuario, u => u.IdUsuario)
                .Where<UsuarioModel>((x, y) => x.IdUsuario > y.IdUsuario && x.DataNascimento == DateTime.Now)
                .Build();

            var list = new List<ClienteModel>();

            list.Any(x => x.Id == 12);
        }
    }

    public class UsuarioMap : EntityMap<UsuarioModel>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");
            Map(x => x.IdUsuario).ToColumn("id");
            Map(x => x.Nome).ToColumn("nome");
            Map(x => x.Sobrenome).ToColumn("sobrenome");
            Map(x => x.Cpf).ToColumn("cpf");
            Map(x => x.Sexo).ToColumn("sexo");
            Map(x => x.DataNascimento).ToColumn("data_nascimento");
        }
    }

    public class ClienteMap : EntityMap<ClienteModel>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            Map(x => x.Id).ToColumn("id");
            Map(x => x.IdUsuario).ToColumn("id_usuario").IsBaseClass();
            Map(x => x.ValorLimite).ToColumn("valor_limite");
            Map(x => x.Observacao).ToColumn("observacao");
        }
    }

    public class EnderecoMap : EntityMap<EnderecoModel>
    {
        public EnderecoMap()
        {
            ToTable("Endereco");
            Map(x => x.Id).ToColumn("id");
            Map(x => x.IdUsuario).ToColumn("id_usuario");
            Map(x => x.Cep).ToColumn("cep");
            Map(x => x.Logradouro).ToColumn("logradouro");
            Map(x => x.Cidade).ToColumn("cidade");
            Map(x => x.Uf).ToColumn("uf");
            Map(x => x.Complemento).ToColumn("complemento");
            Map(x => x.Bairro).ToColumn("bairro");
            Map(x => x.Numero).ToColumn("numero");
        }
    }
}
