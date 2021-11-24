using System.Linq;
using System.Text.RegularExpressions;

namespace CRUD___Adriano.Features.Utils
{
    public static class StringExtension
    {
        public static string RetornarSomenteTextoEmNumeros(this string valor) =>
            string.Join("", new Regex(@"\d+").Matches(valor).Select(x => x.Value));

        public static int IntOuZero(this string valor)
        {
            int.TryParse(valor, out int resultado);
            return resultado;
        }

        public static double DoubleOuZero(this string valor)
        {
            double.TryParse(valor, out double resultado);
            return resultado;
        }

        public static double PorcentoOuZero(this string valor)
        {
            double.TryParse(valor, out double resultado);
            return resultado / 100;
        }

        public static float FloatOuZero(this string valor)
        {
            float.TryParse(valor, out float resultado);
            return resultado;
        }
    }
}
