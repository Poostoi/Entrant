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
        PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
    }

    protected Account()
    {
        
    }
    public Guid Id { get; private init; }
    
    public string Login { get; private init; }

    public string PasswordHash { get; private init; }

    public bool Verify(string password)
    {
        return BCrypt.Net.BCrypt.Verify(password, PasswordHash, false, HashType.None);
    }
    
}
