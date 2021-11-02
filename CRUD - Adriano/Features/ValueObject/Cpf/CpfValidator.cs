using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CRUD___Adriano.Features.ValueObject.Cpf
{
    public class CpfValidator : AbstractValidator<MeuCpf>
    {
        public CpfValidator()
        {
            RuleFor(x => x.ToString()).NotNull().NotEmpty().WithMessage("Cpf não deve ser nulo ou vazio!");
            RuleFor(x => x.ToString()).Length(11).WithMessage("Cpf deve conter 11 números!");
            RuleFor(x => x.ToString()).Must(NumerosNaoRepetidos).WithMessage("Cpf não pode conter todos os números repetidos!");
            RuleFor(x => x.Valido()).Equal(true).WithMessage("Cpf inválido!");
        }

        private static bool NumerosNaoRepetidos(string valor) =>
            !valor.Equals("00000000000") && !valor.Equals("11111111111") &&
            !valor.Equals("22222222222") && !valor.Equals("33333333333") &&
            !valor.Equals("44444444444") && !valor.Equals("55555555555") &&
            !valor.Equals("66666666666") && !valor.Equals("77777777777") &&
            !valor.Equals("88888888888") && !valor.Equals("99999999999");
    }
}
