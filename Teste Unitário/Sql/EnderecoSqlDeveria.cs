using CRUD___Adriano.Features.Entidades.Endereco.Model;
using CRUD___Adriano.Features.Entidades.Endereco.Sql;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Teste_Unitário.Sql
{
    [TestClass]
    public class EnderecoSqlDeveria
    {
        [DataTestMethod]
        [DynamicData(nameof(Lista_para_Deveria_retornar_sql_inserir_corretamente), DynamicDataSourceType.Method)]
        public void Deveria_retornar_sql_inserir_corretamente(EnderecoModel enderecoModel, string sqlEsperado) =>
            Assert.AreEqual(EnderecoSql.Inserir(enderecoModel), sqlEsperado);

        public static IEnumerable<object[]> Lista_para_Deveria_retornar_sql_inserir_corretamente() =>
            new List<object[]>
            {
                new object[]
                {
                    new EnderecoModel(),
                    @"insert into Endereco(id_usuario, logradouro, cidade, uf, complemento, bairro, numero) values (@IdUsuario, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @Numero)"
                },
                new object[]
                {
                    new EnderecoModel { Cep = "123" },
                    @"insert into Endereco(id_usuario, logradouro, cidade, uf, complemento, bairro, numero, cep) values (@IdUsuario, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @Numero, @Cep)"
                },
            };
    }
}
