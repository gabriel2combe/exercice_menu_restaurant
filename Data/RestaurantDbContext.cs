using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApi.Controllers;
using WebApi.Models;

namespace WebApi.Data
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Meal> Meals { get; set; }

        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
    : base(options)
        { }


    }

}
