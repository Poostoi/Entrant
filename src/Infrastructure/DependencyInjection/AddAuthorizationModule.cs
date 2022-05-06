using System.Text;
using Enrollee.Infrastructure.Provider;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Enrollee.Infrastructure.Setting;
using Microsoft.Extensions.Configuration;


namespace DependencyInjection;

public static partial class ServiceCollectionExtensions
{
    public static IServiceCollection AddAuthorizationModule(this IServiceCollection service)
    {
        
        service.AddSingleton<IAuthOptions, AuthOptions>();
        service.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters();
            });
        service.AddAuthorization();
        return service;
    }
}
