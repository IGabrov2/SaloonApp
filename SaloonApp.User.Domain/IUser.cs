using SaloonApp.UserDom.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SaloonApp.UserDom.Domain
{
    public interface IUser
    {
        Task RegisterAsync(User user);
        Task<User> GetUserByIdAsync(string id);
        Task<User> GetUserByEmailAsync(string email);
        Task<List<User>> GetAllUsersAsync();
        Task DeleteUser(string IdUser);
        User UpdateUserEmailConfirmationHelper(User user);
    }
}
