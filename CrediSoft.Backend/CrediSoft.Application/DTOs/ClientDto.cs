using CrediSoft.Domain.Entities;
using CrediSoft.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediSoft.Application.DTOs
{

    public class ClientDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public DocumentType DocumentType { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MaritalStatus { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string AcademicLevel { get; set; } = string.Empty;
        public ClientStatus Status { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public AddressDto Address { get; set; }
        public decimal MonthlyIncome { get; set; }
        public decimal MonthlyExpenses { get; set; }
        public decimal CreditLimit { get; set; }
        public int CreditScore { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }

    public class CreateClientDto
    {
        public string FullName { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public DocumentType DocumentType { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MaritalStatus { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string AcademicLevel { get; set; } = string.Empty;
        public ClientStatus Status { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public AddressDto Address { get; set; }
        public decimal MonthlyIncome { get; set; }
        public decimal MonthlyExpenses { get; set; }
        public decimal CreditLimit { get; set; }
        public int CreditScore { get; set; }
        public bool IsActive { get; set; }
    }

    public class UpdateClientDto
    {
        public string FullName { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public DocumentType DocumentType { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MaritalStatus { get; set; } = string.Empty;
        public string Nacionality { get; set; } = string.Empty;
        public string AcademicLevel { get; set; } = string.Empty;
        public ClientStatus Status { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public AddressDto Address { get; set; }
        public decimal MonthlyIncome { get; set; }
        public decimal MonthlyExpenses { get; set; }
        public decimal CreditLimit { get; set; }
        public int CreditScore { get; set; }
        public bool IsActive { get; set; }
    }

    public class GetClientDto()
    {
        public string FullName { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public DocumentType DocumentType { get; set; }
        public ClientStatus Status { get; set; }
        public decimal MonthlyIncome { get; set; }
        public decimal CreditLimit { get; set; }
        public int CreditScore { get; set; }
    }
}
