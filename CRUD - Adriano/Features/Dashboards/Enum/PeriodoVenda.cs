using System.ComponentModel;

namespace CRUD___Adriano.Features.Dashboards.Enum
{
    public enum PeriodoVenda
    {
        [Description("Hoje")]
        Hoje = 1,

        [Description("Ontem")]
        Ontem = 2,

        [Description("Esta semana")]
        EstaSemana = 3,

        [Description("Mês atual")]
        MesAtual = 4,

        [Description("Mês passado")]
        MesPassado = 5,

        [Description("Últimos 3 meses")]
        Ultimos3Meses = 6,

        [Description("Ano atual")]
        AnoAtual = 7,

        [Description("Ano passado")]
        AnoPassado = 8,
    }
}
