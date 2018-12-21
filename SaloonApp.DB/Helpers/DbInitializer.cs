using Microsoft.EntityFrameworkCore;
using SaloonApp.DB.Helpers.InMemoryObjects;

namespace SaloonApp.DB.Helpers
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.Migrate();

            InitialUsers.Seed(context);
        }
    }
}
