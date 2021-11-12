using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace CRUD___Adriano.Features.Utils
{
    public static class EnumExtension
    {
        public static string RetornarDescricao<Enum>(this Enum valor)
        {
            FieldInfo campo = valor.GetType().GetField(valor.ToString());

            DescriptionAttribute[] atributos = campo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (atributos != null && atributos.Any())
            {
                return atributos.First().Description;
            }

            return valor.ToString();
        }
    }
}
