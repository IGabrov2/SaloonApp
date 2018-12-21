using SaloonApp.Common.Extensions;
using SaloonApp.Common.Helpers;
using SaloonApp.UserDom.Domain;
using SaloonApp.UserDom.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SaloonApp.DB.Helpers.InMemoryObjects
{
    public static class InitialUsers
    {
        public static void Seed(AppDbContext context)
        {
            if (context.Users.Any()) return;
            foreach (var initialUser in GetInitialUsers())
            {
                context.Users.Add(initialUser);
            }
            context.SaveChanges();
        }

        private static List<User> GetInitialUsers()
        {
            return new List<User>()
            {
                new User("Natali","Peneva","natalie@gmail.com","1234",TypeOfUser.Worker),
                new User("Asq","Marinova","asq@gmail.com","1234",TypeOfUser.Admin),
                new User("Tanq","Mitrecksa","tanq@gmail.com","1234",TypeOfUser.Worker)
            };
        }
    }
}
