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
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<bool> AssignRoleAsync(int userId, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ChangeUserStatusAsync(int userId, bool isActive)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserDto?> GetUserByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto?> GetUserByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<UserProfileDto?> GetUserProfileAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> RegisterUserAsync(CreateUserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserAsync(int userId, UpdateUserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateCredentialsAsync(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
