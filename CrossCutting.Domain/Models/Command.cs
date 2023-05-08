using CrossCutting.Domain.Interfaces;

namespace CrossCutting.Domain.Models
{
    public abstract class Command : ICommand
    {
        protected Command()
        {
            CreationTimestamp = DateTime.UtcNow;
        }

        public DateTime CreationTimestamp { get; private set; }
    }
}
