using Kindergarten.Application.Abstractions;
using Kindergarten.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Kindergarten.Application.UseCases.ChildrenServices.Queries;
public class GetChildByIdQueryHandler : IRequestHandler<GetChildByIdQuery, Child>
{
    private readonly IApplicationDbContext _dbContext;

    public GetChildByIdQueryHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Child> Handle(GetChildByIdQuery request, CancellationToken cancellationToken)
    {
        var response = await _dbContext
                .Children
                    .FirstOrDefaultAsync(c => c.Id == request.Id)
                        ?? throw new Exception();

        return response;
    }
}
