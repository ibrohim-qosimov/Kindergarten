using Kindergarten.Application.UseCases.GuardiansServices.Commands;
using Kindergarten.Application.UseCases.GuardiansServices.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Kindergarten.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuardiansController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GuardiansController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateGuardian(CreateGuardianCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGuardianById(int id)
        {
            var query = new GetGuardianByIdQuery()
            {
                Id = id
            };

            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
