using Kindergarten.Application.DTOs;
using MediatR;

namespace Kindergarten.Application.UseCases.Educators.Queries;
public class GetEducatorByIdQuery : IRequest<EducatorDTO>
{
    public int Id { get; set; }
}
