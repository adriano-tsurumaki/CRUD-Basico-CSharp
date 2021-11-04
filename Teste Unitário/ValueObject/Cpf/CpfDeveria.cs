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

            Assert.AreEqual(valorEsperado, cpf.ValorFormatado);
        }
    }
}
