using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Enrollee.Application.Setting;


namespace DependencyInjection;

public static partial class ServiceCollectionExtensions
{
    public static IServiceCollection AddAuthorizationModule(this IServiceCollection service)
    {
        service.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new()
                {
                    ValidateIssuer = true,
                    ValidIssuer = AuthOptions.ISSUER,
                    ValidateAudience = true,
                    ValidAudience = AuthOptions.AUDIENCE,
                    ValidateLifetime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(AuthOptions.KEY)),
                    ValidateIssuerSigningKey = true,
                };
            });
        service.AddAuthorizationModule();
        return service;
    }
}
