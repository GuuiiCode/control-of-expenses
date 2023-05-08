using ControlExpenses.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControlExpenses.Data.Configuration
{
    public class ControlExpenseConfiguration : IEntityTypeConfiguration<ControlExpense>
    {
        public void Configure(EntityTypeBuilder<ControlExpense> entity)
        {
            entity.HasKey(x => x.Id);

            entity.Property(x => x.Description)
                  .HasMaxLength(255)
                  .IsRequired();

            entity.Property(x => x.Value)
                  .HasColumnType("decimal(11,2)")
                  .IsRequired();

            entity.Property(x => x.Type)
                  .IsRequired();

            entity.Property(x => x.Date)
                  .HasColumnType("datetime")
                  .IsRequired();
        }
    }
}
