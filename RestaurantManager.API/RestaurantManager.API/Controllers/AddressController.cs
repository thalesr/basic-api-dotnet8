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
    public class AddressController : GenericController<Address, 
                                                       AddressController, 
                                                       AddressDTO, 
                                                       CreateAddressDTO, 
                                                       UpdateAddressDTO>
    {
        public AddressController(IAddressBusiness addressBusiness, 
                                 ILogger<AddressController> logger, 
                                 IMapper mapper) : base(addressBusiness, logger, mapper)
        {
        }
    }
}
