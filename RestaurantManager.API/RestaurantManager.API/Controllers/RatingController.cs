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
    public class RatingController : GenericController<Rating, 
                                                      RatingController, 
                                                      RatingDTO, 
                                                      CreateRatingDTO, 
                                                      UpdateRatingDTO>
    {
        public RatingController(IRatingBusiness ratingBusiness, ILogger<RatingController> logger, IMapper mapper) : base(ratingBusiness, logger, mapper)
        {
        }
    }
}
