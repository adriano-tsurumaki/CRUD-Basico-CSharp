using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.ValueObject.Porcentagens;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CRUD___Adriano.Features.ValueObject.Precos
{
    public struct Preco
    {
        private double _preco;

        public double Valor { get => _preco; }

        public string Formatado { get => _preco.ToString("C", CultureInfo.CurrentCulture); }

        public Preco(double preco)
        {
            _preco = preco;
        }

        public Preco(string preco)
        {
            preco = preco.Trim();

            if (Regex.IsMatch(preco, @"^([R][$])?\s?\d+[,]\d{1,2}$"))
                _preco = double.Parse(preco, NumberStyles.Currency);
            else
            {
                var valorString = preco.RetornarSomenteTextoEmNumeros();
                valorString = valorString.Length > 2 ? valorString.Insert(valorString.Length - 2, ",") : valorString;
                _preco = valorString.DoubleOuZero();
            }
        }

        public static implicit operator Preco(double preco) => new Preco(preco);
        public static implicit operator Preco(string preco) => new Preco(preco);

        public static Preco operator +(Preco precoA, Preco precoB) => new Preco((double)Math.Round(precoA.Valor + precoB.Valor, 2));
        public static Preco operator -(Preco precoA, Preco precoB) => new Preco((double)Math.Round(precoA.Valor - precoB.Valor, 2));
        public static Preco operator %(Preco precoA, Preco precoB) => new Preco((double)Math.Round(precoA.Valor % precoB.Valor, 2));
        public static Preco operator *(Preco precoA, Preco precoB) => new Preco((double)Math.Round(precoA.Valor * precoB.Valor, 2));
        public static Preco operator /(Preco precoA, Preco precoB) => new Preco((double)Math.Round(precoA.Valor / precoB.Valor, 2));

        public static Preco operator *(Preco preco, Porcentagem porcentagem) 
            => new Preco((double)Math.Round(preco.Valor * porcentagem.Valor));

        public static Preco operator *(Preco preco, int inteiro)
            => new Preco((double)Math.Round(preco.Valor * inteiro));

        public static Preco operator *(Preco preco, double dobro)
            => new Preco((double)Math.Round(preco.Valor * dobro));

        public static Preco operator *(Preco preco, float flutuante)
            => new Preco((double)Math.Round(preco.Valor * flutuante));
    }
}
