using CRUD___Adriano.Features.ValueObject.Cpf;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste_Unitário.ValueObject.Cpf
{
    [TestClass]
    public class CpfValidatorDeveria
    {
        [DataTestMethod]
        [DataRow("", 3, false)]
        [DataRow("123", 2, false)]
        [DataRow("1234567891234", 2,false)]
        [DataRow("11111111111", 2, false)]
        [DataRow("37543212376", 1, false)]
        [DataRow("22893114806", 0, true)]
        public void Deveria_validar_cpf_corretamente(string valor, int quantidadeDeErros, bool validacaoEsperada)
        {
            MeuCpf cpf = valor;
            
            var validator = new CpfValidator();
            var validatorResult = validator.Validate(cpf);

            Assert.AreEqual(validacaoEsperada, validatorResult.IsValid);
            Assert.AreEqual(quantidadeDeErros, validatorResult.Errors.Count);
        }
    }
}
