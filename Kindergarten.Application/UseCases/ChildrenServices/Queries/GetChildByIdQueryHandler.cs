using Kindergarten.Application.Abstractions;
using Kindergarten.Application.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Kindergarten.Application.UseCases.ChildrenServices.Queries;
public class GetChildByIdQueryHandler : IRequestHandler<GetChildByIdQuery, ChildDTO>
{
    private readonly IApplicationDbContext _dbContext;

    public GetChildByIdQueryHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ChildDTO> Handle(GetChildByIdQuery request, CancellationToken cancellationToken)
    {
        var child = await _dbContext
                .Children
                    .FirstOrDefaultAsync(c => c.Id == request.Id)
                        ?? throw new Exception();

        var response = new ChildDTO()
        {
            Id = child.Id,
            FirstName = child.FirstName,
            LastName = child.LastName,
        };

        return response;
    }
}
