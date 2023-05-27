using ControlExpenses.Application.Commands.ControlExpense.Commands;
using FluentValidation;

namespace ControlExpenses.Application.Commands.ControlExpense.Validators
{
    public class DeleteControlExpenseCommandValidator : AbstractValidator<DeleteControlExpenseCommand>
    {
        public DeleteControlExpenseCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O campo id deve ser informado!");
        }
    }
}
