using System;
using BCrypt.Net;

namespace Enrollee.Domain.Models;

public class Account : IEntity
{
    public Account(string login, string password)
    {
        ArgumentNullException.ThrowIfNull(password);
        ArgumentNullException.ThrowIfNull(login);

        Id = Guid.NewGuid();
        Login = login;
        Salt = BCrypt.Net.BCrypt.GenerateSalt();
        PasswordHash = BCrypt.Net.BCrypt.HashPassword((Salt + password));
    }

    protected Account()
    {
        Login = null!;
        PasswordHash = null!;
        Salt = null!;
    }

    public Guid Id { get; private init; }

    public string Login { get; private init; }

    public string Salt { get; private init; }

    public string PasswordHash { get; private init; }

    public bool Verify(string password)
    {
        return BCrypt.Net.BCrypt.Verify((Salt + password), PasswordHash);
    }
}