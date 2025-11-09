using AutoMapper;
using CrediSoft.Application.DTOs;
using CrediSoft.Domain.Entities;

namespace CrediSoft.Application.Profiles
{
    public class LoanProfile : Profile
    {
        public LoanProfile()
        {
            CreateMap<Loan, LoanDto>();
        }
    }
}
