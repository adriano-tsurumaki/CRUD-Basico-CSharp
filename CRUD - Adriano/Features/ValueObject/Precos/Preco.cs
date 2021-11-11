using CRUD___Adriano.Features.Utils;
using System.Globalization;

namespace CRUD___Adriano.Features.ValueObject.Precos
{
    public struct Preco
    {
        private float _preco;

        public float Valor { get => _preco; }

        public string ValorFormatado { get => _preco.ToString("C", CultureInfo.CurrentCulture); }

        public Preco(float preco)
        {
            _preco = preco;
        }

        public Preco(string preco)
        {
            var valorString = preco.RetornarSomenteTextoEmNumeros();
            valorString = valorString.Length > 2 ? valorString.Insert(valorString.Length - 2, ".") : valorString;
            _preco = valorString.FloatOuZero();
        }

        public static implicit operator Preco(float preco) => new Preco(preco);
        public static implicit operator Preco(string preco) => new Preco(preco);

        public static Preco operator +(Preco precoA, Preco precoB) => new Preco(precoA.Valor + precoB.Valor);
        public static Preco operator -(Preco precoA, Preco precoB) => new Preco(precoA.Valor - precoB.Valor);
        public static Preco operator %(Preco precoA, Preco precoB) => new Preco(precoA.Valor % precoB.Valor);
        public static Preco operator *(Preco precoA, Preco precoB) => new Preco(precoA.Valor * precoB.Valor);
        public static Preco operator /(Preco precoA, Preco precoB) => new Preco(precoA.Valor / precoB.Valor);
    }
}
