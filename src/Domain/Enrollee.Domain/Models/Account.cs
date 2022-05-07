using System;
using BCrypt.Net;

namespace Enrollee.Domain.Models;

public class Account : IEntity
{
    public Account(string login, string password, Role role)
    {
        ArgumentNullException.ThrowIfNull(password);
        ArgumentNullException.ThrowIfNull(login);

        Id = Guid.NewGuid();
        Login = login;
        Role = role;
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

    public Guid Id { get; private init; }

    public string Login { get; private init; }
    
    private Role Role { get; set; }

    private string Salt { get; init; }

    private string PasswordHash { get; init; }


    public bool Verify(string password)
    {
        return BCrypt.Net.BCrypt.Verify((Salt + password), PasswordHash);
    }
}