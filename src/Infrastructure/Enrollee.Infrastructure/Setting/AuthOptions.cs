namespace Enrollee.Infrastructure.Setting;

public  class AuthOptions
{
    public static string ISSUER { get; set; } = "";// издатель токена
    public  static string AUDIENCE { get; set; } = "";// потребитель токена
    public  static string KEY { get; set; } = ""; // ключ для шифрации
}