using Kindergarten.Application.Abstractions;
using Kindergarten.Application.DTOs;
using Kindergarten.Domain.Entities;
using MediatR;

namespace Kindergarten.Application.UseCases.GuardiansServices.Commands;
public class CreateGuardianCommandHandler : IRequestHandler<CreateGuardianCommand, ResponseModel>
{
    private readonly IApplicationDbContext _context;

    public CreateGuardianCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ResponseModel> Handle(CreateGuardianCommand request, CancellationToken cancellationToken)
    {
        var myGuardian = new Guardian()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            PhoneNumber = request.PhoneNumber
        };

        await _context.Guardians.AddAsync(myGuardian, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        var response = new ResponseModel()
        {
            IsSuccess = true,
            StatusCode = 200
        };

        return response;
    }
}

