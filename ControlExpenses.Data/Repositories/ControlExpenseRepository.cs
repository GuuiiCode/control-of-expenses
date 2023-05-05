using ControlExpenses.Data.Context;
using ControlExpenses.Domain.Entities;
using ControlExpenses.Domain.Interfaces.Repositories;

namespace ControlExpenses.Data.Repositories
{
    public class ControlExpenseRepository : BaseRepository<ControlExpense>, IControlExpenseRepository
    {
        public ControlExpenseRepository(ControlExpenseContext context) : base(context)
        {
        }
    }
}
