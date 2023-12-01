﻿using Application.Common.Interfaces;

namespace Infrastructure.Services
{
    public class IdentityService : IIdentityService
    {
        public Task<bool> AssignUserToRole(string userName, IList<string> roles)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateRoleAsync(string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<(bool isSucceed, string userId)> CreateUserAsync(string userName, string password, string email, string fullName, List<string> roles)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRoleAsync(string roleId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EmailConfirmed(string userId, string code)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ForgotUserPassword(string email)
        {
            throw new NotImplementedException();
        }

        public Task<List<(string id, string fullName, string userName, string email)>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<(string id, string userName, string email, IList<string> roles)>> GetAllUsersDetailsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(string id, string roleName)> GetRoleByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<(string id, string roleName)>> GetRolesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(string userId, string fullName, string UserName, string email, IList<string> roles)> GetUserDetailsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<(string userId, string fullName, string UserName, string email, IList<string> roles)> GetUserDetailsByUserNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserIdAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserNameAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetUserRolesAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsInRoleAsync(string userId, string role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUniqueUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrationUserAsync(string userName, string password, string email, string fullName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ResetUserPassword(string email, string password, string code)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SigninUserAsync(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRole(string id, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserProfile(string id, string fullName, string email, IList<string> roles)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUsersRole(string userName, IList<string> usersRole)
        {
            throw new NotImplementedException();
        }


    }
}
