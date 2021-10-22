using CRUD___Adriano.Features.Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace CRUD___Adriano.Features.Utils
{
    public static class ComboBoxExtension
    {
        public static void AtribuirPeloEnum<T>(this ComboBoxFlat comboBox)
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T não é um tipo enum");

            var listaDeEnum = new List<string>();
            listaDeEnum.Add("Selecione uma opção");

            foreach (Enum item in Enum.GetValues(typeof(T)))
            {
                Type tipo = item.GetType();
                FieldInfo campo = tipo.GetField(item.ToString());
                DescriptionAttribute[] atributos =
                    campo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

                listaDeEnum.Add(!string.Empty.Equals(atributos[0]?.Description) ? atributos[0].Description : string.Empty);
            }

            comboBox.DataSource = listaDeEnum;
        }

        public static IEnumerable<T> EnumParaIEnumerable<T>()
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T não é um tipo enum");

            foreach (T item in Enum.GetValues(typeof(T)))
            {
                yield return item;
            }
        }

        public static T PegarEnumPorDescricao<T>(this ComboBoxFlat comboBox)
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T não é um tipo enum");

            IList<T> lista = EnumParaIEnumerable<T>().ToList();

            foreach (T item in lista)
                if (RetornarDescricaoEnum(item as Enum) == comboBox.SelectedItem.ToString())
                    return item;

            throw new Exception("A descrição é inválida");
        }

        public static string RetornarDescricaoEnum(Enum valor)
        {
            FieldInfo campo = valor.GetType().GetField(valor.ToString());

            DescriptionAttribute[] atributos = campo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (atributos != null && atributos.Any())
            {
                return atributos.First().Description;
            }

            return valor.ToString();
        }

        public static bool EstaSelecionado(this ComboBoxFlat comboBox) =>
            comboBox.SelectedIndex > 0;
    }
}
