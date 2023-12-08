using AutoMapper;
using RestaurantManager.API.DTO;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.API.Configuration
{
    public class MapperInitializer : Profile
    {

        public MapperInitializer()
        {

            CreateMap<Address, AddressDTO>().ReverseMap();
            CreateMap<Address, CreateAddressDTO>().ReverseMap();
            CreateMap<Address, UpdateAddressDTO>().ReverseMap();

            CreateMap<Driver, DriverDTO>().ReverseMap();
            CreateMap<Driver, CreateDriverDTO>().ReverseMap();
            CreateMap<Driver, UpdateDriverDTO>().ReverseMap();

            CreateMap<Menu, MenuDTO>().ReverseMap();
            CreateMap<Menu, CreateMenuDTO>().ReverseMap();
            CreateMap<Menu, UpdateMenuDTO>().ReverseMap();

            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<Order, CreateOrderDTO>().ReverseMap();
            CreateMap<Order, UpdateOrderDTO>().ReverseMap();

            CreateMap<Payment, PaymentDTO>().ReverseMap();
            CreateMap<Payment, CreatePaymentDTO>().ReverseMap();
            CreateMap<Payment, UpdatePaymentDTO>().ReverseMap();

            CreateMap<Rating, RatingDTO>().ReverseMap();
            CreateMap<Rating, CreateRatingDTO>().ReverseMap();
            CreateMap<Rating, UpdateRatingDTO>().ReverseMap();

            CreateMap<Restaurant, RestaurantDTO>().ReverseMap();
            CreateMap<Restaurant, CreateRestaurantDTO>().ReverseMap();
            CreateMap<Restaurant, UpdateRestaurantDTO>().ReverseMap();

            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, CreateUserDTO>().ReverseMap();
            CreateMap<User, UpdateUserDTO>().ReverseMap();

        }

    }
}
