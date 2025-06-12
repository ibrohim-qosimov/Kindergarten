
using Kindergarten.Domain.DTOs;
using MediatR;

namespace Kindergarten.Application.UseCases.ChildrenServices.Commands;
public class CreateChildCommand : IRequest<ResponseModel>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int GuardianId { get; set; }
}
