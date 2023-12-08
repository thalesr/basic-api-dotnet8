using Microsoft.EntityFrameworkCore;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.Database.Context
{
    public class RestaurantManagerDbContext : DbContext
    {

        public RestaurantManagerDbContext(DbContextOptions<RestaurantManagerDbContext> options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
