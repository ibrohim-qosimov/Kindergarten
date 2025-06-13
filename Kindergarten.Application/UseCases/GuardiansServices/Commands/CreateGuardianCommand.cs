using Kindergarten.Domain.DTOs;
using MediatR;

namespace Kindergarten.Application.UseCases.GuardiansServices.Commands;
public class CreateGuardianCommand : IRequest<ResponseModel>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}
