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
            builder => builder.UseNpgsql("Host=localhost;Port=5432;Database=CoreDomain;Username=postgres;Password=37242"));
        service.AddSingleton<EntityProvider>();
        service.AddCors(o => o.AddPolicy("ReactPolicy", builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        }));
        service.AddScoped<IAccountProvider, AccountProvider>();
        service.AddScoped<IRoleProvider, RoleProvider>();
        service.AddScoped<ITokenProvider, TokenProvider>();


        return service;
    }
}