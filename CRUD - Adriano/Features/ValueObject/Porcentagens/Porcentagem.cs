using CRUD___Adriano.Features.Utils;
using System;

namespace CRUD___Adriano.Features.ValueObject.Porcentagens
{
    public struct Porcentagem
    {
        private readonly double _valor;

        public double Valor { get => _valor; }

        public string Formatado { get => $"{_valor} %"; }

        public Porcentagem(int valor) => _valor = valor;

        public Porcentagem(double valor) => _valor = valor;

        // TODO: Aplicar formatação da string correta na porcentagem e os testes unitários
        public Porcentagem(string valor)
        {
            _valor = valor.Replace("%", "").Trim().DoubleOuZero();
        }

        public static implicit operator Porcentagem(int valor) => new Porcentagem(valor);
        public static implicit operator Porcentagem(double valor) => new Porcentagem(valor);
        public static implicit operator Porcentagem(string valor) => new Porcentagem(valor);
    }
}
