using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_GymManagement.Entities;

namespace MVC_GymManagement.Configurations
{
    public class MemberShipConfigurations : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(MS => MS.Id);
            builder.Property(MS => MS.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(MS => MS.StartDate).HasDefaultValueSql("GETDATE()");

            builder.HasOne(MS => MS.Plan)
                   .WithMany(MS => MS.PlanSubscriptions)
                   .HasForeignKey(MS => MS.PlanId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(MS => MS.Member)
                .WithMany(MS => MS.MemberSubscriptions)
                .HasForeignKey(MS => MS.MemberId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
