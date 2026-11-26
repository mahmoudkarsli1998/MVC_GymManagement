using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_GymManagement.Entities;

namespace MVC_GymManagement.Configurations
{
    public class PlanConfigurations : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(P => P.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(P => P.Price).HasPrecision(10, 2);

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("PlanDurationDaysConstraint", "DurationDays BETWEEN 1 AND 365");
                T.HasCheckConstraint("PlanPriceConstraint", "Price >= 0");
            });

        }
    }
}
