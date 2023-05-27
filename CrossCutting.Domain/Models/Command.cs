using ControlExpenses.CrossCutting.Interfaces;

namespace ControlExpenses.CrossCutting.Models
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
