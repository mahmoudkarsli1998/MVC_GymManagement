using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_GymManagement.Entities;

namespace MVC_GymManagement.Configurations
{
    public class MemberConfigurations:GymUserConfigurations<Member> , IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder) 
        {
            builder.Property(S => S.CreatedAt).HasDefaultValueSql("GETDATE()")
                   .HasColumnName("JoinDate");

            base.Configure(builder);

        }
    }
}
