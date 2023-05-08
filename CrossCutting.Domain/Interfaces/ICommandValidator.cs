using MediatR;

namespace CrossCutting.Domain.Interfaces
{
    public interface ICommandValidator<TEntity> : IRequest<TEntity> where TEntity : ICommand
    {
    }
}
