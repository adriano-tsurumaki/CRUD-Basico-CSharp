using FluentValidation;

namespace CRUD___Adriano.Features.ValueObject.Precos
{
    public class PrecoValidator : AbstractValidator<Preco>
    {
        public PrecoValidator()
        {
            RuleFor(x => x.ToString()).NotNull().NotEmpty().WithMessage("Preço não deve ser nulo ou vazio!");
        }
    }
}
