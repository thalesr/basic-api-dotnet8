using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantManager.API.Controllers.Base;
using RestaurantManager.API.DTO;
using RestaurantManager.Business.Definitions;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.API.Controllers
{
    [Route("api/payments")]
    [ApiController]
    public class PaymentController : GenericController<Payment, 
                                                       PaymentController, 
                                                       PaymentDTO, 
                                                       CreatePaymentDTO, 
                                                       UpdatePaymentDTO>
    {
        public PaymentController(IPaymentBusiness paymentBusiness, 
                                 ILogger<PaymentController> logger, 
                                 IMapper mapper) : base(paymentBusiness, logger, mapper)
        {
        }
    }
}
