using System;

namespace Enrollee.Domain.Models;

public class User : IEntity
{
    public User(string login, string passwordHash)
    {
        ArgumentNullException.ThrowIfNull(passwordHash);
        ArgumentNullException.ThrowIfNull(login);

        Id = Guid.NewGuid();
        Login = login;
        PasswordHash = passwordHash;
    }

    public Guid Id { get; private set; }
    
    public string Login { get; private set; }

    public string PasswordHash { get; private set; }
}
