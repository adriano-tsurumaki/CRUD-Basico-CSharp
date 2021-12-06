using System;

namespace CRUD___Adriano.Features.Utils
{
    public static class DateTimeExtension
    {
        public static DateTime ZerarHorario(this DateTime date) =>
            new DateTime(date.Year, date.Month, date.Day);

        public static DateTime PrimeiroDiaDaSemana(this DateTime date)
        {
            date = ZerarHorario(date);
            var diferenca = (7 + date.DayOfWeek - DayOfWeek.Sunday) % 7;
            return date.AddDays(-1 * diferenca);
        }

        public static DateTime PrimeiroDiaDoMes(this DateTime date)
        {
            date = ZerarHorario(date);
            var diferenca = -1 * (date.Day == 1 ? 0 : date.Day - 1);
            return date.AddDays(diferenca);
        }

        public static DateTime UltimoDiaDoMes(this DateTime date)
        {
            date = ZerarHorario(date);
            var diasDoMes = DateTime.DaysInMonth(date.Year, date.Month);
            var diferenca = diasDoMes - date.Date.Day;
            return date.AddDays(diferenca);
        }

        public static DateTime PrimeiroDiaDoAno(this DateTime date)
        {
            var diferenca = -1 * (date.Month == 1 ? 0 : date.Month - 1);
            return date.AddMonths(diferenca).PrimeiroDiaDoMes();
        }

        public static DateTime UltimoDiaDoAno(this DateTime date) =>
            new DateTime(date.Year, 12, 31);

        public static DateTime MesAnterior(this DateTime date, int intervalo) =>
            date.ZerarHorario().AddMonths(-intervalo);

        public static DateTime AnoAnterior(this DateTime date, int intervalo) =>
            date.ZerarHorario().AddYears(-intervalo);

        public static bool DateMinOuMax(this DateTime dateTime) => 
            dateTime == DateTime.MinValue || dateTime == DateTime.MaxValue;
    }
}
