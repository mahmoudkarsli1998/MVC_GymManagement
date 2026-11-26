using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_GymManagement.Entities;

namespace MVC_GymManagement.Configurations
{
    public class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(GU => GU.Name)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(50);

            builder.Property(GU => GU.Email)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

            builder.Property(GU => GU.Phone)
                .HasColumnType("VARCHAR")
                .HasMaxLength(11);

            builder.HasIndex(GU => GU.Email).IsUnique();
            builder.HasIndex(GU => GU.Phone).IsUnique();

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("GymUser_Email_CK", "Email LIKE '_%@_%._%'");
                T.HasCheckConstraint("GymUser_Phone_CK", "LEN(Phone) = 11 AND (Phone LIKE '010%' OR Phone LIKE '011%' OR Phone LIKE '012%' OR Phone LIKE '015%')");

            });

            builder.ComplexProperty(GU => GU.Address); // Composite Attribute
        }
    }
}
