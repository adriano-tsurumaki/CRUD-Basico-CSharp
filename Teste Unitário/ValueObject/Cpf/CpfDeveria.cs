using CRUD___Adriano.Features.ValueObject.Cpf;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste_Unitário.ValueObject.CpfDeveria
{
    [TestClass]
    public class CpfDeveria
    {
        [DataTestMethod]
        [DataRow("###.###.!!!-@@", "")]
        [DataRow("123.456.78#99)", "")]
        [DataRow("78#99)", "")]
        [DataRow("123", "")]
        [DataRow("123.456.78#99)00", "")]
        [DataRow("123.456.78#99)0", "123.456.789-90")]
        [DataRow("12345678990", "123.456.789-90")]
        public void A_propriedade_ValorFormatado_deve_formatar_corretamente(string valor, string valorEsperado)
        {
            MeuCpf cpf = valor;

            var teste = cpf.ValorFormatado;

            Assert.AreEqual(valorEsperado, cpf.ValorFormatado);
        }

        [DataTestMethod]
        [DataRow("", false)]
        [DataRow("123", false)]
        [DataRow("1234567891234", false)]
        [DataRow("11111111111", false)]
        [DataRow("37543212376", false)]
        [DataRow("22893114806", true)]
        public void Deveria_validar_cpf_corretamente(string valor, bool validacaoEsperada)
        {
            MeuCpf cpf = valor;

            Assert.AreEqual(cpf.ValidarTudo(), validacaoEsperada);
        }
    }
}
