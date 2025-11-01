using CrediSoft.Domain.Entities;
using CrediSoft.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediSoft.Infrastructure.Persistence.Configurations
{
    public class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.ToTable("Loans");
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Id)
                .ValueGeneratedOnAdd();

            builder.Property(l => l.LoanNumber)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(l => l.Currency)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(l => l.PrincipalAmount)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(l => l.InterestRate)
                .HasColumnType("decimal(5,2)");

            builder.Property(l => l.AnnualPercentageRate)
                .HasColumnType("decimal(5,2)");

            builder.Property(l => l.TotalPayable)
                .HasColumnType("decimal(18,2)");

            builder.Property(l => l.RemainingBalance)
                .HasColumnType("decimal(18,2)");

            builder.Property(l => l.PaymentFrequencyDays)
                .IsRequired();

            builder.Property(l => l.TermMonths)
                .IsRequired();

            builder.Property(l => l.StartDate)
                .HasColumnType("date");

            builder.Property(l => l.EndDate)
                .HasColumnType("date");

            builder.Property(l => l.PaymentMethod)
                .HasMaxLength(50);

            builder.Property(l => l.LoanPurpose)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(l => l.LoanType)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(l => l.Status)
                .HasConversion(
                l => l.ToString(),
                l => (LoanStatus)Enum.Parse(typeof(LoanStatus), l));

            builder.Property(l => l.LateFeePercentage)
                .HasColumnType("decimal(5,2)");

            builder.Property(l => l.GracePeriodDays);

            builder.Property(l => l.HasCollateral)
                .HasDefaultValue(false);

            builder.Property(l => l.HasGuarantor)
                .HasDefaultValue(false);

            builder.HasOne(l => l.Client)
                .WithMany(c => c.Loans)
                .HasForeignKey(l => l.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(u => u.LoanNumber)
                .IsUnique();

            builder.HasIndex(u => u.LoanType)
                .IsUnique();

            builder.HasIndex(u => u.Currency)
                .IsUnique();
        }
    }
}
