using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Cliente.Sql;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Teste_Unitário.Sql
{
    [TestClass]
    public class ClienteSqlDeveria
    {
        [DataTestMethod]
        [DynamicData(nameof(Lista_para_Deveria_retornar_sql_inserir_corretamente), DynamicDataSourceType.Method)]
        public void Deveria_retornar_sql_inserir_corretamente(ClienteModel clienteModel, string sqlEsperado) =>
            Assert.AreEqual(ClienteSql.InserirCliente(clienteModel), sqlEsperado);

        public static IEnumerable<object[]> Lista_para_Deveria_retornar_sql_inserir_corretamente() =>
            new List<object[]>
            {
                new object[]
                {
                    new ClienteModel() { Observacao = string.Empty },
                    @"insert into Cliente(id_usuario, valor_limite) values (@IdUsuario, @ValorLimite)"
                },
                new object[]
                {
                    new ClienteModel { Observacao = "123" },
                    @"insert into Cliente(id_usuario, valor_limite, observacao) values (@IdUsuario, @ValorLimite, @Observacao)"
                },
            };
    }
}
