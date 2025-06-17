using Kindergarten.Application.DTOs;
using MediatR;

namespace Kindergarten.Application.UseCases.GuardiansServices.Queries;
public class GetGuardianByIdQuery : IRequest<GuardianDTO>
{
    public int Id { get; set; }
}

