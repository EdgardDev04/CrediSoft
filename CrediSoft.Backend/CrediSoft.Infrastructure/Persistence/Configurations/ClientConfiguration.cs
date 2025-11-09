using CrediSoft.Domain.Entities;
using CrediSoft.Domain.Enums;
using CrediSoft.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediSoft.Infrastructure.Persistence.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");
            builder.HasKey(u => u.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.FullName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(c => c.DocumentNumber)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(c => c.DocumentType)
                .HasConversion(
                c => c.ToString(),
                c => (DocumentType)Enum.Parse(typeof(DocumentType), c));

            builder.Property(c => c.Gender)
                .HasMaxLength(10);

            builder.Property(c => c.DateOfBirth)
                .HasColumnType("date");

            builder.Property(c => c.MaritalStatus)
                .HasMaxLength(50);

            builder.Property(c => c.Nacionality)
                .HasMaxLength(100);

            builder.Property(c => c.AcademicLevel)
                .HasMaxLength(100);

            builder.Property(c => c.Status)
                .HasConversion(
                c => c.ToString(),
                c => (ClientStatus)Enum.Parse(typeof(ClientStatus), c));

            builder.Property(c => c.Email)
                .HasMaxLength(150);

            builder.Property(c => c.PhoneNumber)
                .HasMaxLength(20);

        builder.OwnsOne(c => c.Address, address =>
            {
                address.Property(a => a.Street)
                    .HasColumnName("Street")
                    .HasMaxLength(150);

                address.Property(a => a.City)
                    .HasColumnName("City")
                    .HasMaxLength(100);

                address.Property(a => a.State)
                    .HasColumnName("State")
                    .HasMaxLength(100);

                address.Property(a => a.Country)
                    .HasColumnName("Country")
                    .HasMaxLength(100);

                address.Property(a => a.PostalCode)
                    .HasColumnName("PostalCode")
                    .HasMaxLength(20);
            });

            builder.Property(c => c.MonthlyIncome)
                .HasColumnType("decimal(18,2)");

            builder.Property(c => c.MonthlyExpenses)
                .HasColumnType("decimal(18,2)");

            builder.Property(c => c.CreditLimit)
                .HasColumnType("decimal(18,2)");

            builder.Property(c => c.CreditScore);

            builder.Property(c => c.IsActive)
                .HasDefaultValue(true);

            builder.HasMany(c => c.Loans)
                .WithOne(l => l.Client)
                .HasForeignKey(l => l.ClientId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
