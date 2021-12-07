using CRUD___Adriano.Features.BuildQuery;
using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Entidades.Endereco.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste_Unitário.BuildQuery
{
    [TestClass]
    public class BuildQueryDeveria
    {
        [TestMethod]
        public void Teste()
        {
            var query = new BuildQuery<ClienteModel>()
                .Select(c => c.Cpf)
                .SelectOut<EnderecoModel>(e => e.Bairro);
        }
    }
}
