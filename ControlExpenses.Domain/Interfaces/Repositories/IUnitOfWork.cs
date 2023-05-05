namespace ControlExpenses.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IControlExpenseRepository ControlExpenseRepository { get; }
        int Save();
    }
}
