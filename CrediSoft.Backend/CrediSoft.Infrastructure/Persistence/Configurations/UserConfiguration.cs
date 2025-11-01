using CrediSoft.Domain.Entities;
using CrediSoft.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace CrediSoft.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
               .ValueGeneratedOnAdd();

            builder.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.DocumentNumber)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(u => u.DocumentType)
                .HasConversion(
                u => u.ToString(),
                u => (DocumentType)Enum.Parse(typeof(DocumentType), u));


            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(255); 

            builder.Property(u => u.PhoneNumber)
                .HasMaxLength(20);

            builder.Property(u => u.Role)
                .HasConversion(
                u => u.ToString(),
                u => (UserRole)Enum.Parse(typeof(UserRole), u));

            builder.Property(u => u.IsActive)
                .HasDefaultValue(true);

            builder.Property(u => u.FailedLoginAttempts)
                .HasDefaultValue(0);


            builder.HasIndex(u => u.UserName)
                .IsUnique();

            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.HasIndex(u => u.DocumentNumber)
                .IsUnique();
        }
    }
}
