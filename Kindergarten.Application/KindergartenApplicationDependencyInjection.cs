using Kindergarten.Application.UseCases.ChildrenServices.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Kindergarten.Application;
public static class KindergartenApplicationDependencyInjection
{
    public static IServiceCollection AddKindergartenApplicationDependencyInjection(this IServiceCollection services)
    {
        services.AddMediatR(typeof(GetChildByIdQuery).Assembly);
        return services;
    }
}

