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
    public class DriverController : GenericController<Driver, 
                                                      DriverController, 
                                                      DriverDTO, 
                                                      CreateDriverDTO, 
                                                      UpdateAddressDTO>
    {
        public DriverController(IDriverBusiness driverBusiness, 
                                ILogger<DriverController> logger, 
                                IMapper mapper) : base(driverBusiness, logger, mapper)
        {
        }
    }
}
