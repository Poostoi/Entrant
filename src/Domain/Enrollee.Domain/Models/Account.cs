using System;
using System.Collections.Generic;
using BCrypt.Net;

namespace Enrollee.Domain.Models;

public class Account : BaseModel
{
    public Account(string login, string password)
    {
        ArgumentNullException.ThrowIfNull(password);
        ArgumentNullException.ThrowIfNull(login);

        Login = login;
        Salt = BCrypt.Net.BCrypt.GenerateSalt();
        PasswordHash = BCrypt.Net.BCrypt.HashPassword((Salt + password));
        Roles = Array.Empty<Role>();
    }

    protected Account()
    {
        Login = null!;
        PasswordHash = null!;
        Salt = null!;
        Roles = new List<Role>();
    }

    public string Login { get; private init; }

    public string Salt { get; private init; }
    
    public string PasswordHash { get; private init; }

    public IReadOnlyCollection<Role> Roles { get; private set; }

    public bool Verify(string password) //добавить проверку на наличие ролей
    {
        return BCrypt.Net.BCrypt.Verify((Salt + password), PasswordHash);
    }
}