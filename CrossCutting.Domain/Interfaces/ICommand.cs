using CrossCutting.Domain.Models;
using MediatR;

namespace CrossCutting.Domain.Interfaces
{
    public interface ICommand : IRequest<CommandResult>, IBaseRequest
    {

    }
}
