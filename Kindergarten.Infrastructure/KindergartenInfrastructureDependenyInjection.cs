using Kindergarten.Application.Abstractions;
using Kindergarten.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Kindergarten.Infrastructure;
public static class KindergartenInfrastructureDependenyInjection
{
    public static IServiceCollection AddKindergartenInfrastructureDependenyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IApplicationDbContext,KindergartenDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        });

        return services;
    }
}
