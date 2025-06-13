using Kindergarten.Domain.Entities;
using MediatR;

namespace Kindergarten.Application.UseCases.GuardiansServices.Queries;
public class GetGuardianByIdQuery : IRequest<Guardian>
{
    public int Id { get; set; }
}

