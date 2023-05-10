using CrossCutting.Domain.Models;

namespace ControlExpenses.Application.Commands.ControlExpense.Commands
{
    public class DeleteControlExpenseCommand : Command
    {
        public DeleteControlExpenseCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
