using Microsoft.AspNetCore.Mvc;
using Workers_management.Core.Entities;
using Workers_management.Core.Services;
using Workers_management.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Workers_management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        private readonly IPositionService _positionService; 

        public PositionController(IPositionService positionService)
        {
            _positionService = positionService;
        }

    

        // GET: api/<PositionController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var position = await _positionService.GetPositionsAsync();
            return Ok(position);

        }

        // GET api/<PositionController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var position = await _positionService.GetByIdAsync(id);
            return Ok(position);

        }

        // POST api/<PositionController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Position position)
        {
            var newPosition = await _positionService.AddPositionAsync(position);
            return Ok(newPosition);
        }

        // PUT api/<PositionController>/5
        [HttpPut("{id}")]
        //public async Task<ActionResult> Put(int id, [FromBody] Position position)
        //{
        //    var position1 = await _positionService.UpdatePositionAsync(id, position);
        //    return Ok(position1);

            
        //}

        // DELETE api/<PositionController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var position = await _positionService.GetByIdAsync(id);
            if (position is null)
            {
                return NotFound();
            }
            await _positionService.DeletePositionAsync(id);
            return NoContent();
        }
    }
}
