using RestaurantManager.Database.Context;
using RestaurantManager.Database.Repositories.Definitions;
using RestaurantManager.Database.Repositories.Implementations;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.Database.UOW
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly RestaurantManagerDbContext _context;

        private IGenericRepository<Address> _addresses { get; }
        private IGenericRepository<Driver> _drivers { get; }
        private IGenericRepository<Menu> _menus { get; }
        private IGenericRepository<Order> _orders { get; }
        private IGenericRepository<Payment> _payments { get; }
        private IGenericRepository<Rating> _ratings { get; }
        private IGenericRepository<Restaurant> _restaurants { get; }
        private IGenericRepository<User> _users { get; }

        public UnitOfWork(RestaurantManagerDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Address> Addresses => _addresses ?? new GenericRepository<Address>(_context);
        public IGenericRepository<Driver> Drivers => _drivers ?? new GenericRepository<Driver>(_context);
        public IGenericRepository<Menu> Menus => _menus ?? new GenericRepository<Menu>(_context);
        public IGenericRepository<Order> Orders => _orders ?? new GenericRepository<Order>(_context);
        public IGenericRepository<Payment> Payments => _payments ?? new GenericRepository<Payment>(_context);
        public IGenericRepository<Rating> Ratings => _ratings ?? new GenericRepository<Rating>(_context);
        public IGenericRepository<Restaurant> Restaurants => _restaurants ?? new GenericRepository<Restaurant>(_context);
        public IGenericRepository<User> Users => _users ?? new GenericRepository<User>(_context);
        public RestaurantManagerDbContext Context => _context;

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
