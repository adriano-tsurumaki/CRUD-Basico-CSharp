using CRUD___Adriano.Features.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Teste_Unitário.Extensão
{
    [TestClass]
    public class DateTimeExtensaoDeveria
    {
        [TestMethod]
        public void Deveria_zerar_horario_corretamente()
        {
            var data = DateTime.Now;
            var dataEsperada = DateTime.Now;
            dataEsperada = new DateTime(dataEsperada.Year, dataEsperada.Month, dataEsperada.Day);

            Assert.AreEqual(dataEsperada, data.ZerarHorario());
        }

        [DataTestMethod]
        [DynamicData(nameof(Lista_para_comparar_duas_datas_que_sao_os_primeiros_dias_da_semana), DynamicDataSourceType.Method)]
        public void Deveria_retornar_primeiro_dia_da_semana_corretamente(DateTime data, DateTime dataEsperada) =>
            Assert.AreEqual(dataEsperada, data.PrimeiroDiaDaSemana());

        public static IEnumerable<object[]> Lista_para_comparar_duas_datas_que_sao_os_primeiros_dias_da_semana() =>
            new List<object[]>
            {
                new object[]
                {
                    new DateTime(2021, 11, 30),
                    new DateTime(2021, 11, 28)
                },
                new object[]
                {
                    new DateTime(2021, 12, 01),
                    new DateTime(2021, 11, 28)
                },
                new object[]
                {
                    new DateTime(2021, 12, 02),
                    new DateTime(2021, 11, 28)
                },
                new object[]
                {
                    new DateTime(2021, 11, 27),
                    new DateTime(2021, 11, 21)
                },
            };

        [DataTestMethod]
        [DynamicData(nameof(Lista_para_comparar_duas_datas_que_sao_os_primeiros_dias_do_mes), DynamicDataSourceType.Method)]
        public void Deveria_retornar_primeiro_dia_do_mes_corretamente(DateTime data, DateTime dataEsperada) =>
            Assert.AreEqual(dataEsperada, data.PrimeiroDiaDoMes());

        public static IEnumerable<object[]> Lista_para_comparar_duas_datas_que_sao_os_primeiros_dias_do_mes() =>
            new List<object[]>
            {
                new object[]
                {
                    new DateTime(2021, 11, 10),
                    new DateTime(2021, 11, 01)
                },
                new object[]
                {
                    new DateTime(2021, 11, 20),
                    new DateTime(2021, 11, 01)
                },
                new object[]
                {
                    new DateTime(2021, 11, 30),
                    new DateTime(2021, 11, 01)
                },
                new object[]
                {
                    new DateTime(2021, 01, 31),
                    new DateTime(2021, 01, 01)
                },
                new object[]
                {
                    new DateTime(2021, 02, 28),
                    new DateTime(2021, 02, 01)
                },
                new object[]
                {
                    new DateTime(2021, 03, 15),
                    new DateTime(2021, 03, 01)
                },
                new object[]
                {
                    new DateTime(2021, 04, 01),
                    new DateTime(2021, 04, 01)
                },
                new object[]
                {
                    new DateTime(2021, 05, 04),
                    new DateTime(2021, 05, 01)
                },
                new object[]
                {
                    new DateTime(2021, 06, 25),
                    new DateTime(2021, 06, 01)
                },
                new object[]
                {
                    new DateTime(2020, 02, 29),
                    new DateTime(2020, 02, 01)
                },
            };

        [DataTestMethod]
        [DynamicData(nameof(Lista_para_comparar_duas_datas_que_sao_os_ultimos_dias_do_mes), DynamicDataSourceType.Method)]
        public void Deveria_retornar_ultimo_dia_do_mes_corretamente(DateTime data, DateTime dataEsperada) =>
            Assert.AreEqual(dataEsperada, data.UltimoDiaDoMes());

        public static IEnumerable<object[]> Lista_para_comparar_duas_datas_que_sao_os_ultimos_dias_do_mes() =>
            new List<object[]>
            {
                new object[]
                {
                    new DateTime(2021, 11, 10),
                    new DateTime(2021, 11, 30)
                },
                new object[]
                {
                    new DateTime(2021, 11, 20),
                    new DateTime(2021, 11, 30)
                },
                new object[]
                {
                    new DateTime(2021, 11, 30),
                    new DateTime(2021, 11, 30)
                },
                new object[]
                {
                    new DateTime(2021, 01, 31),
                    new DateTime(2021, 01, 31)
                },
                new object[]
                {
                    new DateTime(2021, 02, 28),
                    new DateTime(2021, 02, 28)
                },
                new object[]
                {
                    new DateTime(2020, 02, 29),
                    new DateTime(2020, 02, 29)
                },
                new object[]
                {
                    new DateTime(2021, 03, 15),
                    new DateTime(2021, 03, 31)
                },
                new object[]
                {
                    new DateTime(2021, 04, 01),
                    new DateTime(2021, 04, 30)
                },
                new object[]
                {
                    new DateTime(2021, 05, 04),
                    new DateTime(2021, 05, 31)
                },
                new object[]
                {
                    new DateTime(2021, 06, 25),
                    new DateTime(2021, 06, 30)
                },
            };

        [DataTestMethod]
        [DynamicData(nameof(Lista_para_comparar_duas_datas_que_sao_os_primeiros_dias_do_ano), DynamicDataSourceType.Method)]
        public void Deveria_retornar_primeiro_dia_do_ano_corretamente(DateTime data, DateTime dataEsperada) =>
            Assert.AreEqual(dataEsperada, data.PrimeiroDiaDoAno());

        public static IEnumerable<object[]> Lista_para_comparar_duas_datas_que_sao_os_primeiros_dias_do_ano() =>
            new List<object[]>
            {
                new object[]
                {
                    new DateTime(2021, 11, 10),
                    new DateTime(2021, 01, 01)
                },
                new object[]
                {
                    new DateTime(2020, 02, 29),
                    new DateTime(2020, 01, 01)
                },
                new object[]
                {
                    new DateTime(2019, 12, 31),
                    new DateTime(2019, 01, 01)
                },
                new object[]
                {
                    new DateTime(2018, 06, 22),
                    new DateTime(2018, 01, 01)
                },
                new object[]
                {
                    new DateTime(2017, 05, 10),
                    new DateTime(2017, 01, 01)
                },
                new object[]
                {
                    new DateTime(2016, 01, 01),
                    new DateTime(2016, 01, 01)
                },
                new object[]
                {
                    new DateTime(2015, 03, 05),
                    new DateTime(2015, 01, 01)
                },
                new object[]
                {
                    new DateTime(2015, 11, 30),
                    new DateTime(2015, 01, 01)
                },
            };

        [DataTestMethod]
        [DynamicData(nameof(Lista_para_comparar_duas_datas_que_sao_os_ultimos_dias_do_ano), DynamicDataSourceType.Method)]
        public void Deveria_retornar_ultimo_dia_do_ano_corretamente(DateTime data, DateTime dataEsperada) =>
            Assert.AreEqual(dataEsperada, data.UltimoDiaDoAno());

        public static IEnumerable<object[]> Lista_para_comparar_duas_datas_que_sao_os_ultimos_dias_do_ano() =>
            new List<object[]>
            {
                new object[]
                {
                    new DateTime(2021, 11, 10),
                    new DateTime(2021, 12, 31)
                },
                new object[]
                {
                    new DateTime(2020, 02, 29),
                    new DateTime(2020, 12, 31)
                },
                new object[]
                {
                    new DateTime(2019, 12, 31),
                    new DateTime(2019, 12, 31)
                },
                new object[]
                {
                    new DateTime(2018, 06, 22),
                    new DateTime(2018, 12, 31)
                },
                new object[]
                {
                    new DateTime(2017, 05, 10),
                    new DateTime(2017, 12, 31)
                },
                new object[]
                {
                    new DateTime(2016, 01, 01),
                    new DateTime(2016, 12, 31)
                },
                new object[]
                {
                    new DateTime(2015, 03, 05),
                    new DateTime(2015, 12, 31)
                },
                new object[]
                {
                    new DateTime(2015, 11, 30),
                    new DateTime(2015, 12, 31)
                },
            };

        [DataTestMethod]
        [DynamicData(nameof(Lista_para_comparar_duas_datas_que_sao_os_meses_anteriores), DynamicDataSourceType.Method)]
        public void Deveria_retornar_mes_anterior_corretamente(DateTime data, int intervalo, DateTime dataEsperada) =>
            Assert.AreEqual(dataEsperada, data.MesAnterior(intervalo));

        public static IEnumerable<object[]> Lista_para_comparar_duas_datas_que_sao_os_meses_anteriores() =>
            new List<object[]>
            {
                new object[]
                {
                    new DateTime(2021, 11, 10),
                    1,
                    new DateTime(2021, 10, 10)
                },
                new object[]
                {
                    new DateTime(2020, 01, 31),
                    2,
                    new DateTime(2019, 11, 30),
                },
                new object[]
                {
                    new DateTime(2021, 12, 15),
                    5,
                    new DateTime(2021, 7, 15),
                },
            };

        [DataTestMethod]
        [DynamicData(nameof(Lista_para_comparar_duas_datas_que_sao_os_anos_anteriores), DynamicDataSourceType.Method)]
        public void Deveria_retornar_ano_anterior_corretamente(DateTime data, int intervalo, DateTime dataEsperada) =>
            Assert.AreEqual(dataEsperada, data.AnoAnterior(intervalo));

        public static IEnumerable<object[]> Lista_para_comparar_duas_datas_que_sao_os_anos_anteriores() =>
            new List<object[]>
            {
                new object[]
                {
                    new DateTime(2021, 11, 10),
                    1,
                    new DateTime(2020, 11, 10)
                },
                new object[]
                {
                    new DateTime(2020, 01, 31),
                    2,
                    new DateTime(2018, 01, 31),
                },
                new object[]
                {
                    new DateTime(2021, 12, 15),
                    5,
                    new DateTime(2016, 12, 15),
                },
            };
    }
}
