using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Kindergarten.Application;
public static class KindergartenApplicationDependencyInjection
{
    public static IServiceCollection AddKindergartenApplicationDependencyInjection(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
}

