using Kindergarten.Application.DTOs;
using MediatR;

namespace Kindergarten.Application.UseCases.Educators.Commands;
public class CreateEducatorCommand : IRequest<ResponseModel>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
}
