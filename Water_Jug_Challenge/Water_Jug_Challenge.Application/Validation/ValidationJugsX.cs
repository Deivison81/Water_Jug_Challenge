using FluentValidation;
using Water_Jug_Challenge.Domain;

namespace Water_Jug_Challenge.Application.Validation
{
    public class ValidationJugsX: AbstractValidator<JugsX>
    {
        public ValidationJugsX()
        {
            RuleFor(r => r.x)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(0)
                .Must(r => r % 1 == 0).WithMessage("El valor debe ser un número entero.");
        }
    }
}
