﻿using BuildQuery;
using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Entidades.Endereco.Model;
using CRUD___Adriano.Features.Usuario.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Teste_Unitário.BuildQuery
{
    [TestClass]
    public class BuildQueryDeveria
    {
        [TestMethod]
        public void Teste()
        {
            var query = new BuildQuery<ClienteModel>()
                .Select(c => c.Id)
                .Select(c => c.IdUsuario)
                .SelectOut<EnderecoModel>(e => e.Bairro)
                .SelectOut<EnderecoModel>(e => e.IdUsuario)
                .InnerJoin<UsuarioModel>(u => u.IdUsuario, e => e.IdUsuario)
                .InnerJoin<EnderecoModel, UsuarioModel>(e => e.IdUsuario, u => u.IdUsuario)
                .Build();

            var lista = new List<EnderecoModel>();

            //lista.Any(x => x.Bairro);
        }
    }
}
