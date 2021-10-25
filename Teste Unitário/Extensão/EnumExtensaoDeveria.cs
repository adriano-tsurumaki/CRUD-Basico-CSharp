using CRUD___Adriano.Features.Estados.Enum;
using CRUD___Adriano.Features.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_Unitário.Extensão
{
    [TestClass]
    public class EnumExtensaoDeveria
    {
        [DataTestMethod]
        [DataRow(EstadosBrasilEnum.AC, "Acre")]
        [DataRow(EstadosBrasilEnum.AL, "Alagoas")]
        [DataRow(EstadosBrasilEnum.SP, "São Paulo")]
        [DataRow(EstadosBrasilEnum.TO, "Tocantins")]
        public void Deveria_retornar_descricao_do_enum_EstadosBrasilEnum(EstadosBrasilEnum estadoEnum, string estadoEsperado)
        {
            Assert.AreEqual(estadoEnum.RetornarDescricao(), estadoEsperado);
        }
    }
}
