using BuildQuery;
using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Entidades.Endereco.Model;
using CRUD___Adriano.Features.Entidades.Telefone.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var query = new BuildQuery<ClienteModel>()
                .Select(c => c.Id)
                .SelectOut<EnderecoModel>(e => e.Bairro)
                .SelectOut<EnderecoModel>(e => e.IdUsuario)
                .SelectOut<TelefoneModel>(e => e.IdUsuario)
                .InnerJoin<EnderecoModel>()
                .Build();

            var lista = new List<EnderecoModel>();

            lista.Select(x => x.Bairro);
        }
    }
}
