using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantManager.API.Controllers.Base;
using RestaurantManager.API.DTO;
using RestaurantManager.Business.Definitions;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : GenericController<User, 
                                                    UserController, 
                                                    UserDTO, 
                                                    CreateUserDTO, 
                                                    UpdateUserDTO>
    {
        public UserController(IUserBusiness userBusiness, 
                              ILogger<UserController> logger, 
                              IMapper mapper) : base(userBusiness, logger, mapper)
        {
        }
    }
}
