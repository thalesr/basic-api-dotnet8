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
    public class OrderController : GenericController<Order, 
                                                     OrderController, 
                                                     OrderDTO, 
                                                     CreateOrderDTO, 
                                                     UpdateOrderDTO>
    {
        public OrderController(IOrderBusiness orderBusiness, 
                               ILogger<OrderController> logger, 
                               IMapper mapper) : base(orderBusiness, logger, mapper)
        {
        }
    }
}
