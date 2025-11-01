using CrediSoft.Domain.ValueObjects;
using CrediSoft.Domain.Enums;

namespace CrediSoft.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public DocumentType DocumentType { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MaritalStatus { get; set; } = string.Empty;
        public string Nacionality { get; set; } = string.Empty;
        public string AcademicLevel { get; set; } = string.Empty;
        public ClientStatus Status {  get; set; } 
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public Address Address { get; set; }
        public decimal MonthlyIncome { get; set; }
        public decimal MonthlyExpenses { get; set; }
        public decimal CreditLimit { get; set; }
        public int CreditScore { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
