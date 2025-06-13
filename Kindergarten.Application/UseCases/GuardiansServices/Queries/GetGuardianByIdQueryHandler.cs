using Kindergarten.Application.Abstractions;
using Kindergarten.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Kindergarten.Application.UseCases.GuardiansServices.Queries;
public class GetGuardianByIdQueryHandler : IRequestHandler<GetGuardianByIdQuery, Guardian>
{
    private readonly IApplicationDbContext _context;

    public GetGuardianByIdQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Guardian> Handle(GetGuardianByIdQuery request, CancellationToken cancellationToken)
    {
        var myGuardian = await _context.Guardians.Include(g=>g.Children).FirstOrDefaultAsync(g => g.Id == request.Id, cancellationToken)
            ?? throw new Exception();

        return myGuardian;
    }
}
