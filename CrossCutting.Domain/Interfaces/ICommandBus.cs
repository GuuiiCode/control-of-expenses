using ControlExpenses.CrossCutting.Models;

namespace ControlExpenses.CrossCutting.Interfaces
{
    public interface ICommandBus
    {
        Task<CommandResult> Send(ICommand command, CancellationToken cancellationToken = default);
    }
}
