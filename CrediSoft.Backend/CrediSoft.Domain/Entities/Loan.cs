using CrediSoft.Domain.Enums;
using CrediSoft.Domain.ValueObjects;

namespace CrediSoft.Domain.Entities
{
    public class Loan
    {
        public int Id { get; set; }
        public string LoanNumber { get; set; }
        public decimal PrincipalAmount { get; set; }
        public string Currency {  get; set; }
        public decimal InterestRate { get; set; }
        public decimal AnnualPercentageRate { get; set; }
        public int TermMonths { get; set; }
        public int PaymentFrequencyDays { get; set; }
        public decimal TotalPayable { get; set; }
        public decimal RemainingBalance { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PaymentMethod { get; set; }
        public bool HasCollateral { get; set; }
        public bool HasGuarantor { get; set; }
        public string LoanPurpose { get; set; } = null!;
        public string LoanType { get; set; } = null!;
        public LoanStatus Status { get; set; }
        public decimal LateFeePercentage { get; set; }
        public int GracePeriodDays { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
