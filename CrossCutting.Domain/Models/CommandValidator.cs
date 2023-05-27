using ControlExpenses.CrossCutting.Interfaces;
using FluentValidation;

namespace ControlExpenses.CrossCutting.Models
{
    public class CommandValidator<TEntity> : AbstractValidator<TEntity>, ICommandValidator<TEntity> where TEntity : Command
    {
    }
}
