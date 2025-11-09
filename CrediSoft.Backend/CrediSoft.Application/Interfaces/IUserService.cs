using CrediSoft.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediSoft.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> RegisterUserAsync(CreateUserDto userDto);
        Task<bool> UpdateUserAsync(int userId, UpdateUserDto userDto);
        Task<UserDto?> GetUserByIdAsync(int userId);
        Task<UserDto?> GetUserByUsernameAsync(string username);
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task<bool> ChangeUserStatusAsync(int userId, bool isActive);
        Task<bool> DeleteUserAsync(int userId);
        Task<bool> AssignRoleAsync(int userId, string roleName);
        Task<bool> ValidateCredentialsAsync(string username, string password);
        Task<UserProfileDto?> GetUserProfileAsync(int userId);
    }
}
