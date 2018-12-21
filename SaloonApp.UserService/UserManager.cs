using Microsoft.EntityFrameworkCore;
using SaloonApp.Common.Extensions;
using SaloonApp.DB;
using SaloonApp.UserDom.Domain;
using SaloonApp.UserDom.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaloonApp.UserService
{
    public class UserManager: IUser
    {
        private readonly AppDbContext _ctx;

        public UserManager()
        {
            this._ctx = new AppDbContext();
        }

        public async Task DeleteUser(string IdUser)
        {
            var user = await GetUserByIdAsync(IdUser);
            _ctx.Users.Attach(user);
            _ctx.Users.Remove(user);
            _ctx.SaveChanges();
        }

        public async Task<List<User>> GetAllUsersAsync() => await _ctx.Users.ToListAsync();

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _ctx.Users.FirstOrDefaultAsync(u => u.Email == email);         
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            List<User> users = await _ctx.Users.ToListAsync();
            return users.FirstOrDefault(u => u.Id == id);
        }

        public async Task RegisterAsync(User user)
        {
            await _ctx.Users.AddAsync(user);
            await _ctx.SaveChangesAsync();
        }

        public User UpdateUserEmailConfirmationHelper(User user)
        {
            var updatedUser = new User(
                user.FirstName,
                user.LastName,
                user.Email,
                user.Password,
                user.TypeOfUser,
                user.ValidationCode,
                true,
                new CustomId(new Guid(user.Id)),
                DateTime.Now
            );
            return updatedUser;
        }
    }
}
