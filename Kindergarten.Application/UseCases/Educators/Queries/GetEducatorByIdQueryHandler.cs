using Kindergarten.Application.Abstractions;
using Kindergarten.Application.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Kindergarten.Application.UseCases.Educators.Queries;
public class GetEducatorByIdQueryHandler : IRequestHandler<GetEducatorByIdQuery, EducatorDTO>
{
    private readonly IApplicationDbContext _context;

    public GetEducatorByIdQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<EducatorDTO> Handle(GetEducatorByIdQuery request, CancellationToken cancellationToken)
    {
        var educator = await _context
            .Educators
                .FirstOrDefaultAsync(e => e.Id == request.Id, cancellationToken)
                    ?? throw new Exception();

        var response = new EducatorDTO()
        {
            Id = educator.Id,
            FirstName = educator.FirstName,
            LastName = educator.LastName,
            PhoneNumber = educator.PhoneNumber
        };

        return response;
    }
}
