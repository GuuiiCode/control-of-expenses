using ControlExpenses.Data.Configuration;
using ControlExpenses.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControlExpenses.Data.Context
{
    public class ControlExpenseContext : DbContext
    {
        public ControlExpenseContext(DbContextOptions<ControlExpenseContext> options) 
            : base(options) { }

        public DbSet<ControlExpense> ControlExpenses { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ControlExpenseConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
