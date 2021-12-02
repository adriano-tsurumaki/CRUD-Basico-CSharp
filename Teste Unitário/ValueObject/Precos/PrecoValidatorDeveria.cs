using CRUD___Adriano.Features.ValueObject.Precos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste_Unitário.ValueObject.Precos
{
    [TestClass]
    public class PrecoValidatorDeveria
    {
        [DataTestMethod]
        [DataRow("", 0, true)]
        public void Deveria_validar_preco_corretamente(string valor, int quantidadeDeErros, bool validacaoEsperada)
        {
            Preco preco = valor;

            var validator = new PrecoValidator();
            var validatorResult = validator.Validate(preco);

            Assert.AreEqual(validacaoEsperada, validatorResult.IsValid);
            Assert.AreEqual(quantidadeDeErros, validatorResult.Errors.Count);
        }
    }
}
