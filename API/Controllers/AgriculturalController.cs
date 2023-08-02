using Application.Agricultural.Request;
using Application.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgriculturalController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AgriculturalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<AgriculturalController>
        [HttpGet]
        public async Task<ActionResult<List<AgriculturalDTO>>> GetAll()
        {
            var agriculture = await _mediator.Send(new GetAllAgricultureRequest());
            return Ok(agriculture);
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<AgriculturalDTO>>> Get(Guid Id)
        {
            var agriculture = await _mediator.Send(new GetAgricultureByIdRequest { Id = Id });
            return Ok(agriculture);
        }


        // POST api/<DepartmentController>
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] AgriculturalDTO agriculture)
        {
            var command = new CreateAgricultureRequest { agricultureDTO = agriculture };
            await _mediator.Send(command);
            return Ok(command);

        }

        // PUT api/<DepartmentController>/5
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] AgriculturalDTO agriculture)
        {
            var command = new UpdateAgricultureRequest {agriculturalDTO = agriculture };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid Id)
        {
            var command = new DeleteAgricultureRequest { Id = Id };
            await _mediator.Send(command);
            return NoContent();
        }

    }
}
