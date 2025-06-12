using Kindergarten.Domain.Entities;
using MediatR;

namespace Kindergarten.Application.UseCases.ChildrenServices.Queries;
public class GetChildByIdQuery : IRequest<Child>
{
    public int Id { get; set; }
}
