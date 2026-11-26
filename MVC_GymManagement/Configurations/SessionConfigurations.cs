using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_GymManagement.Entities;

namespace MVC_GymManagement.Configurations
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(S => S.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("SessionCapacityConstraint", "Capacity BETWEEN 1 AND 25");
                T.HasCheckConstraint("SessionEndDateAfterStartDateConstraint", "EndDate > StartDate");
            });

            builder.HasOne(S => S.Trainer)
                .WithMany(T => T.Sessions)
                .HasForeignKey(S => S.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
