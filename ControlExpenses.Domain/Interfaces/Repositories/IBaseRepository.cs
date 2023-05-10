using System.Linq.Expressions;

namespace ControlExpenses.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity?> GetAsync(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
