namespace ControlExpenses.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IControlExpenseRepository ControlExpenseRepository { get; }
        Task<int> SaveAsync();
    }
}
