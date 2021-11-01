using System;
using System.Collections.Generic;
using System.Text;
using CRUD___Adriano.Features.Utils;

namespace CRUD___Adriano.Features.ValueObject.Cpf
{
    public struct MeuCpf
    {
        private readonly string _valor;

        public string ValorFormatado 
        { 
            get => Convert.ToUInt64(_valor).ToString(@"000\.000\.000\-00");
        }

        public MeuCpf(string valor)
        {
           _valor = valor.RetornarSomenteTextoEmNumeros();
        }

        public bool Valido()
        {
            if (string.IsNullOrEmpty(_valor)) return false;

            return true;
        }

        public override string ToString() =>
            _valor;

        public static implicit operator MeuCpf(string valor) => new MeuCpf(valor);
    }
}
