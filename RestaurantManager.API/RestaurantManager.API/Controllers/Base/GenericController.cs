using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantManager.API.DTO.Base;
using RestaurantManager.Business.Definitions.Base;
using RestaurantManager.Model.Entities.Base;

namespace RestaurantManager.API.Controllers.Base
{
    public abstract class GenericController<T, K, N, C, U> : ControllerBase where T : BaseEntity
                                                                            where K : class
                                                                            where N : BaseDTO
                                                                            where C : BaseCreateDTO
                                                                            where U : BaseUpdateDTO
    {

        protected readonly IGenericBusiness<T> _genericBusiness;
        protected readonly ILogger<K> _logger;
        protected readonly IMapper _mapper;

        public GenericController(IGenericBusiness<T> genericBusiness, ILogger<K> logger, IMapper mapper)
        {
            _genericBusiness = genericBusiness;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<N>>> GetAll()
        {
            var data = await _genericBusiness.GetAll();
            var result = _mapper.Map<List<N>>(data);
            return Ok(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<N>> GetById(int id)
        {

            if (id <= 0)
            {
                _logger.LogError("Given ID is invalid");
                return BadRequest();
            }

            var data = await _genericBusiness.GetById(id);
            if (data == null)
            {
                _logger.LogError("Given ID is invalid");
                return BadRequest();
            }

            var result = _mapper.Map<N>(data);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public virtual async Task<ActionResult> Post([FromBody] C obj)
        {

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid POST attempt");
                return BadRequest(ModelState);
            }

            var mappedObj = _mapper.Map<T>(obj);
            await _genericBusiness.Save(mappedObj);
            return Created();

        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public virtual async Task<IActionResult> Put(int id, [FromBody] U obj)
        {

            if (!ModelState.IsValid || id <= 0)
            {
                _logger.LogError("Invalid UPDATE attempt");
                return BadRequest(ModelState);
            }

            var item = await _genericBusiness.GetById(id);
            if (item == null)
            {
                _logger.LogError("Invalid UPDATE attempt");
                return BadRequest("Submitted data is invalid");
            }

            var mappedObj = _mapper.Map(obj, item);
            await _genericBusiness.Save(mappedObj);
            return NoContent();

        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public virtual async Task<IActionResult> Delete(int id)
        {

            if (id <= 0)
            {
                _logger.LogError("Invalid DELETE attempt");
                return BadRequest();
            }

            var item = await _genericBusiness.GetById(id);
            if (item == null)
            {
                _logger.LogError("Invalid DELETE attempt");
                return BadRequest("Submitted data is invalid");
            }

            await _genericBusiness.Delete(id);
            return NoContent();

        }

    }
}
