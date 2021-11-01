using CRUD___Adriano.Features.Cliente.Model;
using CRUD___Adriano.Features.Colaborador.Dao;
using CRUD___Adriano.Features.Entidades.Endereco.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Teste_Unitário.Dao.Colaborador
{
    [TestClass]
    public class MapearListagemDeColaboradorDeveria
    {
        [DataTestMethod]
        [DynamicData(nameof(Lista_para_Deveria_retornar_quantidade_de_colaboradores_corretamente), DynamicDataSourceType.Method)]
        public void Deveria_retornar_quantidade_de_colaboradores_corretamente(IList<ColaboradorModel> listaDeColaboradores, int quantidadeEsperada)
        {
            var dicionarioColaborador = new Dictionary<int, ColaboradorModel>();
            
            foreach (var colaboradorModel in listaDeColaboradores)
                ColaboradorDao.MapearListagemDeColaborador(colaboradorModel, colaboradorModel.Endereco, dicionarioColaborador);

            Assert.AreEqual(dicionarioColaborador.Count, quantidadeEsperada);
        }

        public static IEnumerable<object[]> Lista_para_Deveria_retornar_quantidade_de_colaboradores_corretamente() =>
            new List<object[]>
            {
                new object[]
                {
                    new List<ColaboradorModel>
                    {
                        new ColaboradorModel { IdUsuario = 1, Endereco = new EnderecoModel { Id = 1 } },
                        new ColaboradorModel { IdUsuario = 2, Endereco = new EnderecoModel { Id = 2 } },
                        new ColaboradorModel { IdUsuario = 3, Endereco = new EnderecoModel { Id = 3 } },
                    },
                    3
                },
                new object[]
                {
                    new List<ColaboradorModel>
                    {
                        new ColaboradorModel { IdUsuario = 1, Endereco = new EnderecoModel { Id = 1 } },
                        new ColaboradorModel { IdUsuario = 2, Endereco = new EnderecoModel { Id = 2 } },
                        new ColaboradorModel { IdUsuario = 2, Endereco = new EnderecoModel { Id = 3 } },
                    },
                    2
                },
            };
    }
}
