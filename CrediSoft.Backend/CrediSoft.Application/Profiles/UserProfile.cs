using AutoMapper;
using CrediSoft.Application.DTOs;
using CrediSoft.Domain.Entities;

namespace CrediSoft.Application.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
