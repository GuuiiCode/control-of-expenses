using ControlExpenses.Domain.Enums;

namespace ControlExpenses.Application.Commands.ControlExpense.Commands
{
    public class UpdateControlExpenseCommand : ControlExpenseCommand
    {
        public UpdateControlExpenseCommand(string description, 
                                           decimal value, 
                                           TypeEnum type, 
                                           DateTime date) : base(description, value, type, date) { }

        public int Id { get; set; }
    }
}
