using CRUD___Adriano.Features.ValueObject.Precos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste_Unitário.ValueObject.Precos
{
    [TestClass]
    public class PrecoDeveria
    {
        [DataTestMethod]
        [DataRow("R$12,34", 12.34d)]
        [DataRow("R$12,3", 12.3d)]
        [DataRow("R$ 12,34", 12.34d)]
        [DataRow("R$ 12,3", 12.3d)]
        [DataRow(" R$ 12,34", 12.34d)]
        [DataRow("R$ 12,34 ", 12.34d)]
        [DataRow(" R$ 12,34 ", 12.34d)]
        [DataRow("12,34", 12.34d)]
        [DataRow(" 12,34", 12.34d)]
        [DataRow("12,34 ", 12.34d)]
        [DataRow(" 12,34 ", 12.34d)]
        [DataRow("R$ 12,34,32", 1234.32d)]
        [DataRow("12,34,32", 1234.32d)]
        [DataRow("R$ 12!34,32", 1234.32d)]
        public void DeveriaFormatarAStringCorretamenteNoConstrutor(string valor, double valorFormatado)
        {
            Preco preco = valor;
            Assert.AreEqual(valorFormatado, preco.Valor);
        }

        [DataTestMethod]
        [DataRow(10d, 10d, 20d)]
        [DataRow(10d, 30d, 40d)]
        [DataRow(10.6d, 30.4d, 41d)]
        public void DeveriaSomarPrecosCorretamente(double a, double b, double esperado)
        {
            Preco precoA = a;
            Preco precoB = b;
            Preco precoEsperado = esperado;

            Assert.AreEqual(precoEsperado.Valor, (precoA + precoB).Valor);
        }

        [DataTestMethod]
        [DataRow(10d, 10d, 0d)]
        [DataRow(10d, 30d, -20d)]
        [DataRow(10.6d, 30.4d, -19.8d)]
        public void DeveriaSubtrairPrecosCorretamente(double a, double b, double esperado)
        {
            Preco precoA = a;
            Preco precoB = b;
            Preco precoEsperado = esperado;

            Assert.AreEqual(precoEsperado.Valor, (precoA - precoB).Valor);
        }

        [DataTestMethod]
        [DataRow(10d, 10d, 100d)]
        [DataRow(10d, 30d, 300d)]
        [DataRow(10.6d, 30.4d, 322.24d)]
        public void DeveriaMultiplicarPrecosCorretamente(double a, double b, double esperado)
        {
            Preco precoA = a;
            Preco precoB = b;
            Preco precoEsperado = esperado;

            Assert.AreEqual(precoEsperado.Valor, (precoA * precoB).Valor);
        }

        [DataTestMethod]
        [DataRow(10d, 10d, 1d)]
        [DataRow(10d, 30d, 0.33d)]
        [DataRow(10.6d, 30.4d, 0.35d)]
        public void DeveriaDividirPrecosCorretamente(double a, double b, double esperado)
        {
            Preco precoA = a;
            Preco precoB = b;
            Preco precoEsperado = esperado;

            Assert.AreEqual(precoEsperado.Valor, (precoA / precoB).Valor);
        }

        [DataTestMethod]
        [DataRow(10d, 10d, 0d)]
        [DataRow(10d, 30d, 10d)]
        [DataRow(10.6d, 30.4d, 10.6d)]
        public void DeveriaModularPrecosCorretamente(double a, double b, double esperado)
        {
            Preco precoA = a;
            Preco precoB = b;
            Preco precoEsperado = esperado;

            Assert.AreEqual(precoEsperado.Valor, (precoA % precoB).Valor);
        }
    }
}
