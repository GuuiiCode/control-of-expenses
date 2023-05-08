using ControlExpenses.Application.Commands.ControlExpense.Commands;
using CrossCutting.Domain.Interfaces;
using CrossCutting.Domain.Models;

namespace ControlExpenses.Application.Commands.ControlExpense.CommandHandlers
{
    public class UpdateCommandHandler : ICommandHandler<ControlExpenseCommand>
    {
        public Task<CommandResult> Handle(ControlExpenseCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
