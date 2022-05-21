using Microsoft.Extensions.Configuration;

namespace Enrollee.Infrastructure.Setting;

public class AuthOptions : IAuthOptions
{
    private readonly IConfiguration _configuration;
    public AuthOptions(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string Issuer => _configuration.GetValue<string>("AuthOptions:Issuer");

    public string Audience => _configuration.GetValue<string>("AuthOptions:Audience");

    public string Key=> _configuration.GetValue<string>("AuthOptions:Key");

}