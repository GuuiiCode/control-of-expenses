using CrossCutting.Domain.Models;

namespace CrossCutting.Domain.Interfaces
{
    public interface ICommandBus
    {
        Task<CommandResult> Send(ICommand command, CancellationToken cancellationToken = default);
    }
}
