using ControlExpenses.Application.Commands.ControlExpense.Commands;
using FluentValidation;

namespace ControlExpenses.Application.Commands.ControlExpense.Validators
{
    public class UpdateControlExpenseCommandValidator : ControlExpenseCommandValidator<UpdateControlExpenseCommand>
    {
        public UpdateControlExpenseCommandValidator() : base()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O campo id deve ser informado!");
        }
    }
}
