using Kindergarten.Application.Abstractions;
using Kindergarten.Domain.DTOs;
using Kindergarten.Domain.Entities;
using MediatR;

namespace Kindergarten.Application.UseCases.ChildrenServices.Commands;
public class CreateChildCommandHandler : IRequestHandler<CreateChildCommand, ResponseModel>
{
    private readonly IApplicationDbContext _dbContext;

    public CreateChildCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ResponseModel> Handle(CreateChildCommand request, CancellationToken cancellationToken)
    {
        var myChild = new Child()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Age = request.Age,
            GuardianId = request.GuardianId,
        };

        await _dbContext.Children.AddAsync(myChild, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);

        var response = new ResponseModel()
        {
            IsSuccess = true,
            StatusCode = 200,
        };

        return response;
    }
}

