using System.Linq;
using System.Text.RegularExpressions;

namespace CRUD___Adriano.Features.Utils
{
    public static class StringExtension
    {
        public static string RetornarSomenteNumeros(this string valor) =>
            string.Join("", new Regex(@"[0-9]+").Matches(valor).Select(x => x.Value));
    }
}
