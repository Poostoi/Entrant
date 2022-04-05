using System;

namespace Enrollee.Domain.Models;

public class User : IEntity
{
    public User(string login, string password)
    {
        ArgumentNullException.ThrowIfNull(password);
        ArgumentNullException.ThrowIfNull(login);

        Id = Guid.NewGuid();
        Login = login;
        Password = password;
    }

    public Guid Id { get; private set; }
    
    public string Login { get; private set; }

    public string Password { get; private set; }
}
