using Kindergarten.Application.UseCases.ChildrenServices.Commands;
using Kindergarten.Application.UseCases.ChildrenServices.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kindergarten.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrenController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ChildrenController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateChild(CreateChildCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetChildById(int id)
        {
            var query = new GetChildByIdQuery()
            {
                Id = id
            };

            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
