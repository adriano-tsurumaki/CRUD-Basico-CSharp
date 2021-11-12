using CRUD___Adriano.Features.Utils;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CRUD___Adriano.Features.ValueObject.Precos
{
    public struct Preco
    {
        private float _preco;

        public float Valor { get => _preco; }

        public string Formatado { get => _preco.ToString("C", CultureInfo.CurrentCulture); }

        public Preco(float preco)
        {
            _preco = preco;
        }

        public Preco(string preco)
        {
            preco = preco.Trim();

            if (Regex.IsMatch(preco, @"^([R][$])?\s?\d+[,]\d{1,2}$"))
                _preco = float.Parse(preco, NumberStyles.Currency);
            else
            {
                var valorString = preco.RetornarSomenteTextoEmNumeros();
                valorString = valorString.Length > 2 ? valorString.Insert(valorString.Length - 2, ",") : valorString;
                _preco = valorString.FloatOuZero();
            }
        }

        public static implicit operator Preco(float preco) => new Preco(preco);
        public static implicit operator Preco(string preco) => new Preco(preco);

        public static Preco operator +(Preco precoA, Preco precoB) => new Preco(precoA.Valor + precoB.Valor);
        public static Preco operator -(Preco precoA, Preco precoB) => new Preco(precoA.Valor - precoB.Valor);
        public static Preco operator %(Preco precoA, Preco precoB) => new Preco((float)Math.Round(precoA.Valor % precoB.Valor, 2));
        public static Preco operator *(Preco precoA, Preco precoB) => new Preco((float)Math.Round(precoA.Valor * precoB.Valor, 2));
        public static Preco operator /(Preco precoA, Preco precoB) => new Preco((float)Math.Round(precoA.Valor / precoB.Valor, 2));
    }
}
