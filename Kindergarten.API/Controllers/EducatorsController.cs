using Kindergarten.Application.UseCases.Educators.Commands;
using Kindergarten.Application.UseCases.Educators.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Kindergarten.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducatorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EducatorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEducator(CreateEducatorCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEducatorById(int id)
        {
            var query = new GetEducatorByIdQuery()
            {
                Id = id
            };

            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
