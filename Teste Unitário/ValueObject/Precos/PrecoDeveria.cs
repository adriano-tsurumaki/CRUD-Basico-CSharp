using CRUD___Adriano.Features.ValueObject.Precos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste_Unitário.ValueObject.Precos
{
    [TestClass]
    public class PrecoDeveria
    {
        [DataTestMethod]
        [DataRow("R$12,34", 12.34f)]
        [DataRow("R$12,3", 12.3f)]
        [DataRow("R$ 12,34", 12.34f)]
        [DataRow("R$ 12,3", 12.3f)]
        [DataRow(" R$ 12,34", 12.34f)]
        [DataRow("R$ 12,34 ", 12.34f)]
        [DataRow(" R$ 12,34 ", 12.34f)]
        [DataRow("12,34", 12.34f)]
        [DataRow(" 12,34", 12.34f)]
        [DataRow("12,34 ", 12.34f)]
        [DataRow(" 12,34 ", 12.34f)]
        [DataRow("R$ 12,34,32", 1234.32f)]
        [DataRow("12,34,32", 1234.32f)]
        [DataRow("R$ 12!34,32", 1234.32f)]
        public void DeveriaFormatarAStringCorretamenteNoConstrutor(string valor, float valorFormatado)
        {
            Preco preco = valor;
            Assert.AreEqual(valorFormatado, preco.Valor);
        }

        [DataTestMethod]
        [DataRow(10f, 10f, 20f)]
        [DataRow(10f, 30f, 40f)]
        [DataRow(10.6f, 30.4f, 41f)]
        public void DeveriaSomarPrecosCorretamente(float a, float b, float esperado)
        {
            Preco precoA = a;
            Preco precoB = b;
            Preco precoEsperado = esperado;

            Assert.AreEqual(precoEsperado.Valor, (precoA + precoB).Valor);
        }

        [DataTestMethod]
        [DataRow(10f, 10f, 0f)]
        [DataRow(10f, 30f, -20f)]
        [DataRow(10.6f, 30.4f, -19.8f)]
        public void DeveriaSubtrairPrecosCorretamente(float a, float b, float esperado)
        {
            Preco precoA = a;
            Preco precoB = b;
            Preco precoEsperado = esperado;

            Assert.AreEqual(precoEsperado.Valor, (precoA - precoB).Valor);
        }

        [DataTestMethod]
        [DataRow(10f, 10f, 100f)]
        [DataRow(10f, 30f, 300f)]
        [DataRow(10.6f, 30.4f, 322.24f)]
        public void DeveriaMultiplicarPrecosCorretamente(float a, float b, float esperado)
        {
            Preco precoA = a;
            Preco precoB = b;
            Preco precoEsperado = esperado;

            Assert.AreEqual(precoEsperado.Valor, (precoA * precoB).Valor);
        }

        [DataTestMethod]
        [DataRow(10f, 10f, 1f)]
        [DataRow(10f, 30f, 0.33f)]
        [DataRow(10.6f, 30.4f, 0.35f)]
        public void DeveriaDividirPrecosCorretamente(float a, float b, float esperado)
        {
            Preco precoA = a;
            Preco precoB = b;
            Preco precoEsperado = esperado;

            Assert.AreEqual(precoEsperado.Valor, (precoA / precoB).Valor);
        }

        [DataTestMethod]
        [DataRow(10f, 10f, 0f)]
        [DataRow(10f, 30f, 10f)]
        [DataRow(10.6f, 30.4f, 10.6f)]
        public void DeveriaModularPrecosCorretamente(float a, float b, float esperado)
        {
            Preco precoA = a;
            Preco precoB = b;
            Preco precoEsperado = esperado;

            Assert.AreEqual(precoEsperado.Valor, (precoA % precoB).Valor);
        }
    }
}
