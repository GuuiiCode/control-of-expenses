using ControlExpenses.CrossCutting.Models;
using MediatR;

namespace ControlExpenses.CrossCutting.Interfaces
{
    public interface ICommand : IRequest<CommandResult>, IBaseRequest
    {

    }
}
