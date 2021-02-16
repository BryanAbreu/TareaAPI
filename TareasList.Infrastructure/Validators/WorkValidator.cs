using FluentValidation;
using TareasList.Core.Entities;

namespace TareasList.Infrastructure.Validators
{
    public class WorkValidator : AbstractValidator<Work>
    {
        public WorkValidator()
        {
            RuleFor(x=>x.Description).NotNull().NotEmpty().Length(1,500);
            RuleFor(x => x.Status).NotNull();
        }
    }
}
