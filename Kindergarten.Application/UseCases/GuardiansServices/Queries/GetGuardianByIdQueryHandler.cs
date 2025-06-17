using Kindergarten.Application.Abstractions;
using Kindergarten.Application.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Kindergarten.Application.UseCases.GuardiansServices.Queries;
public class GetGuardianByIdQueryHandler : IRequestHandler<GetGuardianByIdQuery, GuardianDTO>
{
    private readonly IApplicationDbContext _context;

    public GetGuardianByIdQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<GuardianDTO> Handle(GetGuardianByIdQuery request, CancellationToken cancellationToken)
    {
        var myGuardian = await _context.Guardians
            .Include(g => g.Children)
                .FirstOrDefaultAsync(g => g.Id == request.Id, cancellationToken)
                    ?? throw new Exception();

        var response = new GuardianDTO
        {
            Id = myGuardian.Id,
            FirstName = myGuardian.FirstName,
            LastName = myGuardian.LastName,
            Children = myGuardian.Children.Select(c => new ChildDTO
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName
            }).ToList()
        };

        return response;
    }
}
