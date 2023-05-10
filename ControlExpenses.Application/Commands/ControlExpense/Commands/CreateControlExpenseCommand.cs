using ControlExpenses.Domain.Enums;

namespace ControlExpenses.Application.Commands.ControlExpense.Commands
{
    public class CreateControlExpenseCommand : ControlExpenseCommand
    {
        public CreateControlExpenseCommand(string description, 
                                           decimal value, 
                                           TypeEnum type, 
                                           DateTime date) : base(description, value, type, date) { }
    }
}
