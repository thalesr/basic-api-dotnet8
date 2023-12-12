using AutoMapper;
using RestaurantManager.Business.Definitions;
using Microsoft.AspNetCore.Mvc;
using RestaurantManager.API.Controllers.Base;
using RestaurantManager.API.DTO;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : GenericController<User,
                                                    UserController,
                                                    UserDTO,
                                                    CreateUserDTO,
                                                    UpdateUserDTO>
    {

        private readonly IOrderBusiness _orderBusiness;
        private readonly IUserBusiness _userBusiness;

        public UserController(IUserBusiness userBusiness,
                              IOrderBusiness orderBusiness,
                              ILogger<UserController> logger,
                              IMapper mapper) : base(userBusiness, logger, mapper)
        {
            _orderBusiness = orderBusiness;
            _userBusiness = userBusiness;
        }

        [HttpGet("{userId}/orders")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<OrderDTO>>> GetOrdersByUserId(int userId)
        {

            if (userId <= 0)
                return BadRequest();

            var user = await _userBusiness.GetById(userId);
            if (user == null)
                return BadRequest();

            var data = await _orderBusiness.GetByUserId(userId);
            var orders = _mapper.Map<List<OrderDTO>>(data);

            return Ok(orders);

        }
    }
}
