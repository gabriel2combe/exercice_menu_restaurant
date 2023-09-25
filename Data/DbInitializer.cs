using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RestaurantDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded, we don't create other users.
            }

            var users = new User[]
            {
            // Users added for creation database.
            new User{FirstName="John", LastName="Doe", Email="john.doe@example.com", Address="123 Main St", Phone="123-456-7890"},
            new User{FirstName="Jane", LastName="Doe", Email="jane.doe@example.com", Address="777 Mall St", Phone="130-600-7900"},
            new User{FirstName="Irvin", LastName="Lok", Email="Irvin.Lok@example.com", Address="6607 Grand Street", Phone="135-423-1223"},
            };

            foreach (User u in users)
            {
                context.Users.Add(u);
            }

            context.SaveChanges();
        }
    }

}
