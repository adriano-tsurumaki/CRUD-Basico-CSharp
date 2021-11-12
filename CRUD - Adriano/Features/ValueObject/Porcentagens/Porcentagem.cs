using CRUD___Adriano.Features.Utils;
using System;

namespace CRUD___Adriano.Features.ValueObject.Porcentagens
{
    public struct Porcentagem
    {
        private readonly float _valor;

        public float Valor { get => _valor; }

        public string Formatado { get => $"{_valor} %"; }

        public Porcentagem(int valor)
        {
            _valor = (float)Math.Round(valor / 100f, 2);
        }

        // TODO: Aplicar formatação da string correta na porcentagem e os testes unitários
        public Porcentagem(string valor)
        {
            _valor = valor.Replace("%", "").Trim().FloatOuZero();
        }

        public static implicit operator Porcentagem(int valor) => new Porcentagem(valor);
        public static implicit operator Porcentagem(string valor) => new Porcentagem(valor);
    }
}
