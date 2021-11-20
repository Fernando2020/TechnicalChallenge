using FluentValidation;
using TechnicalChallenge.Core.Entities;

namespace TechnicalChallenge.Manager.Validators
{
    public class DividerValidator : AbstractValidator<Divider>
    {
        public DividerValidator()
        {
            RuleFor(x => x.Number)
                .NotNull().GreaterThan(0).WithMessage("Digite um número maior que zero (0).");
        }
    }
}
