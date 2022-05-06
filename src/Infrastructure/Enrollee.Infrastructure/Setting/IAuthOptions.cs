namespace Enrollee.Infrastructure.Setting;

public interface IAuthOptions
{
    public string Issuer { get; } // издатель токена
    public string Audience { get; } // потребитель токена
    public string Key { get; }
    
}