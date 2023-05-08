using CrossCutting.Domain.Models;
using MediatR;

namespace CrossCutting.Domain.Interfaces
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, CommandResult> where TCommand : ICommand
    {
    }
}
