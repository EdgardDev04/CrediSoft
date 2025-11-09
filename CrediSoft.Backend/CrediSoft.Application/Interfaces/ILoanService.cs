using CrediSoft.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediSoft.Application.Interfaces
{
    public interface ILoanService
    {
        Task<LoanDto> CreateLoanAsync(CreateLoanDto loanDto);
        Task<bool> UpdateLoanAsync(int loanId, UpdateLoanDto loanDto);
        Task<LoanDto?> GetLoanByIdAsync(int loanId);
        Task<IEnumerable<LoanDto>> GetAllLoansAsync();
        Task<IEnumerable<LoanDto>> GetLoansByClientIdAsync(int clientId);
        Task<IEnumerable<LoanDto>> GetOverdueLoansAsync();
        Task<bool> ChangeLoanStatusAsync(int loanId, string newStatus);
        Task<bool> DeleteLoanAsync(int loanId);
    }
}
