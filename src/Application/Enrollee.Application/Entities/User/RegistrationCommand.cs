using System;
using Enrollee.Domain.Models;

namespace Enrollee.Application.Entities.User;

public class RegistrationCommand
{
    public RegistrationCommand(string login, string password, Role role)
    {
        ArgumentNullException.ThrowIfNull(login);
        ArgumentNullException.ThrowIfNull(role);
        ArgumentNullException.ThrowIfNull(password);
        
        Login = login;
        Role = role;
        Password = password;
    }

    public string Login { get; private set; }
    public Role Role { get; set; }

    public string Password { get; private set; }
}