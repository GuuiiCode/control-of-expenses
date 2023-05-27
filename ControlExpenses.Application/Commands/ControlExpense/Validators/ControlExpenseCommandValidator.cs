using ControlExpenses.Application.Commands.ControlExpense.Commands;
using ControlExpenses.CrossCutting.Models;
using FluentValidation;

namespace ControlExpenses.Application.Commands.ControlExpense.Validators
{
    public abstract class ControlExpenseCommandValidator<TCommand> : CommandValidator<TCommand> where TCommand : ControlExpenseCommand
    {
        public ControlExpenseCommandValidator()
        {
            RuleFor(command => command.Description)
                .NotEmpty()
                .WithMessage("O campo descrição é obrigatório!");

            RuleFor(command => command.Value)
                .NotEmpty()
                .WithMessage("O campo valor é obrigatório!");

            RuleFor(command => command.Type).IsInEnum();

            RuleFor(command => command.Date).NotEmpty();
        }
    }
}
