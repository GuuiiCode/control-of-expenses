using ControlExpenses.Domain.Enums;

namespace ControlExpenses.Domain.Entities
{
    public class ControlExpense : BaseEntity
    {
        public ControlExpense(string description, 
                              decimal value,
                              TypeEnum type,
                              DateTime date)
        {
            Description = description;
            Value = value;
            Type = type;
            Date = date;
            //ValidateFields();
        }

        public string Description { get; private set; }
        public decimal Value { get; private set; }
        public TypeEnum Type { get; private set; }
        public DateTime Date { get; private set; }

        public void Change(string description,
                           decimal value,
                           TypeEnum type,
                           DateTime date)
        {
            Description = description;
            Value = value;
            Type = type;
            Date = date;
        }

        //Todo - Implementar fluentValidation
        //private void ValidateFields()
        //{
        //    Check.NotEmptyNotNull(Description, nameof(Description));
        //    Check.NotNull(Value, nameof(Value));
        //    Check.NotNull(Type, nameof(Type));
        //}
    }
}
