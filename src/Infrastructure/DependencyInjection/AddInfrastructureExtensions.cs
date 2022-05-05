using Enrollee.Application.Services.User;
using Enrollee.Infrastructure.Contexts;
using Enrollee.Infrastructure.Provider;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection;

public static partial class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection service)
    {
        service.AddDbContext<ServerDbContext>(
            builder => builder.UseInMemoryDatabase("EnrolleeDb"));
        service.AddSingleton<EntityProvider>();
        service.AddScoped<IAccountProvider, AccountProvider>();
        service.AddScoped<ITokenProvider, TokenProvider>();


        return service;
    }
}