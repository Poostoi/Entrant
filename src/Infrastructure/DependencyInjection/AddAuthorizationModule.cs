using System;
using Enrollee.Infrastructure.Provider;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Enrollee.Infrastructure.Setting;
using Microsoft.Extensions.Configuration;


namespace DependencyInjection;

public static partial class ServiceCollectionExtensions
{
    public static IServiceCollection AddAuthorizationModule(this IServiceCollection service, IConfiguration config)
    {
        ArgumentNullException.ThrowIfNull(config);
        
        service.AddSingleton<IAuthOptions, AuthOptions>();
        service.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenProvider(new AuthOptions(config)).CreateTokenValidationParameters();
            });
        service.AddAuthorization();
        return service;
    }
}
