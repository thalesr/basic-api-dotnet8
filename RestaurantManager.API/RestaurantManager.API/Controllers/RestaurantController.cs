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
    public class RestaurantController : GenericController<Restaurant, 
                                                          RestaurantController, 
                                                          RestaurantDTO, 
                                                          CreateRestaurantDTO, 
                                                          UpdateRestaurantDTO>
    {
        public RestaurantController(IRestaurantBusiness restaurantBusiness, 
                                    ILogger<RestaurantController> logger, 
                                    IMapper mapper) : base(restaurantBusiness, logger, mapper)
        {
        }
    }
}
