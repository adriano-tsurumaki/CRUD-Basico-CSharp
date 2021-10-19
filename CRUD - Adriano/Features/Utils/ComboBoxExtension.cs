using CRUD___Adriano.Features.Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CRUD___Adriano.Features.Utils
{
    public static class ComboBoxExtension
    {
        public static void AtribuirPeloEnum<T>(this ComboBoxFlat comboBox)
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T não é um tipo enum");

            var listaDeEnum = new List<string>();

            foreach (Enum item in Enum.GetValues(typeof(T)))
            {
                Type tipo = item.GetType();
                FieldInfo campo = tipo.GetField(item.ToString());
                DescriptionAttribute[] atributos =
                    campo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

                listaDeEnum.Add(string.Empty.Equals(atributos[0]?.Description) ? atributos[0].Description : string.Empty);
            }

            comboBox.DataSource = listaDeEnum;
        }
    }
}
