using Kindergarten.Application.Abstractions;
using Kindergarten.Application.DTOs;
using Kindergarten.Domain.Entities;
using MediatR;

namespace Kindergarten.Application.UseCases.Educators.Commands;
public class CreateEducatorCommandHandler : IRequestHandler<CreateEducatorCommand, ResponseModel>
{
    private readonly IApplicationDbContext _context;

    public CreateEducatorCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ResponseModel> Handle(CreateEducatorCommand request, CancellationToken cancellationToken)
    {
        var myEducator = new Educator()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Age = request.Age,
            PhoneNumber = request.PhoneNumber,
        };

        await _context.Educators.AddAsync(myEducator, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return new ResponseModel()
        {
            IsSuccess = true,
            StatusCode = 200
        };

    }
}
