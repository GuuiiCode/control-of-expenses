using CrossCutting.Domain.Interfaces;
using FluentValidation;

namespace CrossCutting.Domain.Models
{
    public class CommandValidator<TEntity> : AbstractValidator<TEntity>, ICommandValidator<TEntity> where TEntity : Command
    {
    }
}
