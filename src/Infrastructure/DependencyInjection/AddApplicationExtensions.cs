using Enrollee.Application.Services.User;
using Microsoft.Extensions.DependencyInjection;


namespace DependencyInjection;

public static partial class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection service)
    {
        service.AddScoped<IRegistrationService, RegistrationService>();
        service.AddScoped<ILoginService, LoginService>();
        service.AddScoped<IAddRoleService, AddRoleService>();
        return service;
    }
}
