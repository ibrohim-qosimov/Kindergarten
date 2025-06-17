using Kindergarten.Application.DTOs;
using MediatR;

namespace Kindergarten.Application.UseCases.ChildrenServices.Queries;
public class GetChildByIdQuery : IRequest<ChildDTO>
{
    public int Id { get; set; }
}
