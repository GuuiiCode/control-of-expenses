using ControlExpenses.CrossCutting.Models;
using MediatR;

namespace ControlExpenses.CrossCutting.Interfaces
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, CommandResult> where TCommand : ICommand
    {
    }
}
