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
    public class MenuController : GenericController<Menu, 
                                                    MenuController, 
                                                    MenuDTO, 
                                                    CreateMenuDTO, 
                                                    UpdateMenuDTO>
    {
        public MenuController(IMenuBusiness menuBusiness, 
                              ILogger<MenuController> logger, 
                              IMapper mapper) : base(menuBusiness, logger, mapper)
        {
        }
    }
}
