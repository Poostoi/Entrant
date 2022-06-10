using System;
using System.Text;


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

        var authOptions = config
            .GetSection(nameof(AuthOptions))
            .Get<AuthOptions>(options => options.BindNonPublicProperties = true);

        service.AddSingleton(authOptions);
        service.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    //todo: FIX!!!!!!!!!!!!!!!!
                    ValidateIssuer = false,
                    ValidIssuer = authOptions.Issuer,
                    ValidateAudience = false,
                    ValidAudience = authOptions.Audience,
                    ValidateLifetime = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authOptions.Key)),
                    ValidateIssuerSigningKey = true,
                    RequireExpirationTime = false,
                    // ClockSkew = TimeSpan.FromDays(1),
                };
            });
        service.AddAuthorization();
        return service;
    }
}
