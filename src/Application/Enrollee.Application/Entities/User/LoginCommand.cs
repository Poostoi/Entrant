using System;

namespace Enrollee.Application.Entities.User;

public class LoginCommand
{
    public LoginCommand(string login, string password)
    {
        ArgumentNullException.ThrowIfNull(login);
        ArgumentNullException.ThrowIfNull(password);

        Login = login;
        Password = password;
    }

    public string Login { get; private set; }

    public string Password { get; private set; }
}
