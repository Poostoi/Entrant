using System;
using BCrypt.Net;

namespace Enrollee.Domain.Models;

public class Account : BaseModel
{
    public Account(string login, string password):base()
    {
        ArgumentNullException.ThrowIfNull(password);
        ArgumentNullException.ThrowIfNull(login);

        Login = login;
        Salt = BCrypt.Net.BCrypt.GenerateSalt();
        PasswordHash = BCrypt.Net.BCrypt.HashPassword((Salt + password));
    }

    protected Account()
    {
        Login = null!;
        PasswordHash = null!;
        Salt = null!;
        Role = null!;
    }

    public string Login { get; private init; }

    public Role? Role { get; set; }

    public string Salt { get; init; }

    public string PasswordHash { get; init; }



    public bool Verify(string password)
    {
        return BCrypt.Net.BCrypt.Verify((Salt + password), PasswordHash);
    }
}