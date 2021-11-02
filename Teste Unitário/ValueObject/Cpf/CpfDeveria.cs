using CRUD___Adriano.Features.ValueObject.Cpf;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste_Unitário.ValueObject.CpfDeveria
{
    [TestClass]
    public class CpfDeveria
    {
        [DataTestMethod]
        [DataRow("123.456.78#99)0", "123.456.789-90")]
        public void A_propriedade_ValorFormatado_deve_formatar_corretamente(string valor, string valorEsperado)
        {
            MeuCpf cpf = valor;

            Assert.AreEqual(valorEsperado, cpf.ValorFormatado);
        }

        [DataTestMethod]
        [DataRow("", "O Cpf não pode ser nulo ou vazio!")]
        [DataRow("123", "O Cpf não possui exatos 11 números!")]
        [DataRow("1234567891234", "O Cpf não possui exatos 11 números!")]
        [DataRow("11111111111", "O Cpf não pode ter todos os números repetidos!")]
        [DataRow("37543212376", "O Cpf não é válido!")]
        public void Deveria_retornar_mensagem_de_erro_corretamente(string valor, string erroEsperado)
        {
            MeuCpf cpf = valor;

            cpf.Valido();

            Assert.AreEqual(cpf.Error, erroEsperado);
        }
    }
}
