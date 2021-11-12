using CRUD___Adriano.Features.Utils;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Text.RegularExpressions;

namespace CRUD___Adriano.Features.ValueObject.Cpf
{
    public struct MeuCpf
    {
        private readonly string _valor;

        public string Formatado
        {
            get
            {
                if (_valor.Length != 11 || string.IsNullOrEmpty(_valor))
                    return string.Empty;
                return Convert.ToUInt64(_valor).ToString(@"000\.000\.000\-00");
            }
        }

        public MeuCpf(string valor)
        {
           _valor = valor.RetornarSomenteTextoEmNumeros();
        }

        public ValidationResult ValidarTudo()
        {
            return new CpfValidator().Validate(this);
        }

        public bool ValidarCpf()
        {
            if (string.IsNullOrEmpty(_valor) || _valor.Length != 11) return false;

            if (_valor.Equals("00000000000") ||
                _valor.Equals("11111111111") ||
                _valor.Equals("22222222222") ||
                _valor.Equals("33333333333") ||
                _valor.Equals("44444444444") ||
                _valor.Equals("55555555555") ||
                _valor.Equals("66666666666") ||
                _valor.Equals("77777777777") ||
                _valor.Equals("88888888888") ||
                _valor.Equals("99999999999")) return false;

            if (!ValidarPorPartes(10, 9) || !ValidarPorPartes(11, 10)) return false;

            return true;
        }

        private bool ValidarPorPartes(int limite, int posicaoDigito)
        {
            var resultado = 0;

            for (var i = limite; i > 1; i--)
            {
                if (!char.IsDigit(_valor[limite - i]))
                    return false;
                resultado += (_valor[limite - i] - '0') * i;
            }

            resultado = (resultado * 10 % 11) == 10 ? 0 : resultado * 10 % 11;
            return resultado == _valor[posicaoDigito] - '0';
        }
        
        public override string ToString() =>
            _valor;

        public static implicit operator MeuCpf(string valor) => new MeuCpf(valor);
    }
}
