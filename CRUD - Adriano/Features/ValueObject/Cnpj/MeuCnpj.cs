using CRUD___Adriano.Features.Utils;
using System;

namespace CRUD___Adriano.Features.ValueObject.Cnpj
{
    public struct MeuCnpj
    {
        private readonly string _valor;

        public string ValorFormatado
        {
            get
            {
                if (_valor.Length != 14 || string.IsNullOrEmpty(_valor))
                    return string.Empty;
                return Convert.ToUInt64(_valor).ToString(@"00\.000\.000\/0000\-00");
            }
        }

        public MeuCnpj(string valor)
        {
            _valor = valor.RetornarSomenteTextoEmNumeros();
        }

        public override string ToString() =>
           _valor;

        public static implicit operator MeuCnpj(string valor) => new MeuCnpj(valor);
    }
}
