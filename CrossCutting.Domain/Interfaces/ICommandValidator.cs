using MediatR;

namespace ControlExpenses.CrossCutting.Interfaces
{
    public interface ICommandValidator<TEntity> : IRequest<TEntity> where TEntity : ICommand
    {
    }
}
