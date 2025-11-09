using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CrediSoft.Application.DTOs;
using CrediSoft.Application.Interfaces;
using CrediSoft.Domain.Interfaces;

namespace CrediSoft.Application.Services
{
    public class LoanService : ILoanService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LoanService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<bool> ChangeLoanStatusAsync(int loanId, string newStatus)
        {
            throw new NotImplementedException();
        }

        public Task<LoanDto> CreateLoanAsync(CreateLoanDto loanDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteLoanAsync(int loanId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LoanDto>> GetAllLoansAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LoanDto?> GetLoanByIdAsync(int loanId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LoanDto>> GetLoansByClientIdAsync(int clientId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LoanDto>> GetOverdueLoansAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateLoanAsync(int loanId, UpdateLoanDto loanDto)
        {
            throw new NotImplementedException();
        }
    }
}
