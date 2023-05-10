using ControlExpenses.Domain.Enums;
using CrossCutting.Domain.Models;

namespace ControlExpenses.Application.Commands.ControlExpense.Commands
{
    public abstract class ControlExpenseCommand : Command
    {
        public ControlExpenseCommand(string description,
                                     decimal value,
                                     TypeEnum type,
                                     DateTime date)
        {
            Description = description;
            Value = value;
            Type = type;
            Date = date;
        }

        public string Description { get; private set; }
        public decimal Value { get; private set; }
        public TypeEnum Type { get; private set; }
        public DateTime Date { get; private set; }
    }
}
