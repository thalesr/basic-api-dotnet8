using RestaurantManager.Database.Context;
using RestaurantManager.Database.Repositories.Definitions;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.Database.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        public IGenericRepository<Address> Addresses{ get; }
        public IGenericRepository<Driver> Drivers{ get; }
        public IGenericRepository<Menu> Menus{ get; }
        public IGenericRepository<Order> Orders{ get; }
        public IGenericRepository<Payment> Payments{ get; }
        public IGenericRepository<Rating> Ratings{ get; }
        public IGenericRepository<Restaurant> Restaurants{ get; }
        public IGenericRepository<User> Users{ get; }

        RestaurantManagerDbContext Context { get; }
        Task Save();

    }
}
