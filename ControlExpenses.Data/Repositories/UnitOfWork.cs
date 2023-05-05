using ControlExpenses.Data.Context;
using ControlExpenses.Domain.Interfaces.Repositories;

namespace ControlExpenses.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ControlExpenseContext _context;

        public UnitOfWork(ControlExpenseContext context) 
        {
            _context = context;
            ControlExpenseRepository = new ControlExpenseRepository(_context);
        }

        public IControlExpenseRepository ControlExpenseRepository { get; private set; }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
