using Microsoft.Extensions.Configuration;

namespace Enrollee.Infrastructure.Setting;

public class AuthOptions : IAuthOptions
{
    private readonly IConfiguration _configuration;

    public AuthOptions(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string Issuer => _configuration["setting:ISSUER"];

    public string Audience => _configuration["setting:AUDIENCE"];
    

    public string Key => _configuration["setting:KEY"];

}