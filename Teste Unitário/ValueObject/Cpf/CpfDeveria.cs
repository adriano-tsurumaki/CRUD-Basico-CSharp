using CRUD___Adriano.Features.ValueObject.Cpf;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste_Unitário.ValueObject.CpfDeveria
{
    [TestClass]
    public class CpfDeveria
    {
        [TestMethod]
        public void O_Getter_e_Setter_deve_funcionar_corretamente()
        {
            MeuCpf cpf = "123.456.78#99)0";

            var valor = "123.456.789-90";

            Assert.AreEqual(valor, cpf.ValorFormatado);
        }
    }
}
