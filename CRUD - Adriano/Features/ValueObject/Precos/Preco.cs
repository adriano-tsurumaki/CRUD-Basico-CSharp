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
            _preco = Math.Round(preco, 2);
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

        public static Preco operator +(Preco precoA, Preco precoB) => new Preco(Math.Round(precoA.Valor + precoB.Valor, 2));
        public static Preco operator -(Preco precoA, Preco precoB) => new Preco(Math.Round(precoA.Valor - precoB.Valor, 2));
        public static Preco operator %(Preco precoA, Preco precoB) => new Preco(Math.Round(precoA.Valor % precoB.Valor, 2));
        public static Preco operator *(Preco precoA, Preco precoB) => new Preco(Math.Round(precoA.Valor * precoB.Valor, 2));
        public static Preco operator /(Preco precoA, Preco precoB) => new Preco(Math.Round(precoA.Valor / precoB.Valor, 2));

        public static Preco operator *(Preco preco, Porcentagem porcentagem) 
            => new Preco(Math.Round(preco.Valor * porcentagem.Valor, 2));

        public static Preco operator *(Preco preco, int inteiro)
            => new Preco(Math.Round(preco.Valor * inteiro, 2));

        public static Preco operator *(Preco preco, double dobro)
            => new Preco(Math.Round(preco.Valor * dobro, 2));

        public static Preco operator *(Preco preco, float flutuante)
            => new Preco(Math.Round(preco.Valor * flutuante, 2));

        public static bool operator >(Preco precoA, Preco precoB)
            => precoA.Valor > precoB.Valor;

        public static bool operator <(Preco precoA, Preco precoB)
            => precoA.Valor < precoB.Valor;

        public static bool operator ==(Preco precoA, Preco precoB)
            => precoA.Valor == precoB.Valor;

        public static bool operator !=(Preco precoA, Preco precoB)
            => precoA.Valor != precoB.Valor;
    }
}
