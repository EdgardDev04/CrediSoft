using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CrediSoft.Application.DTOs;
using CrediSoft.Application.Interfaces;
using CrediSoft.Domain.Entities;
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

        public async Task<bool> ChangeLoanStatusAsync(int loanId, string newStatus)
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

        public async Task<IEnumerable<LoanDto>> GetAllLoansAsync()
        {
            var getloans = await _unitOfWork.Loan.GetAllAsync();

            var loans = _mapper.Map<IEnumerable<LoanDto>>(getloans);

            return loans;
        }

        public async Task<LoanDto?> GetLoanByIdAsync(int loanId)
        {
            var getloan = await _unitOfWork.Loan.GetByIdAsync(loanId);

            var loan = _mapper.Map<Loan, LoanDto>(getloan);

            return loan;
        }

        public async Task<IEnumerable<LoanDto>> GetLoansByClientIdAsync(int clientId)
        {
            var getloans = await _unitOfWork.Loan.GetByClientIdAsync(clientId);

            var loans = _mapper.Map<IEnumerable<LoanDto>>(getloans);

            return loans;
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
