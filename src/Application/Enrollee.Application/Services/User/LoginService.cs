using System;
using System.Threading;
using System.Threading.Tasks;
using Enrollee.Application.Entities.User;
using Enrollee.Domain.Models;

namespace Enrollee.Application.Services.User;

internal sealed class LoginService : ILoginService
{
    private readonly IUserProvider _userProvider;

    public LoginService(IUserProvider userProvider)
    {
        ArgumentNullException.ThrowIfNull(userProvider);

        _userProvider = userProvider;
    }

    public async Task<Guid> HandleAsync(RegistrationCommand command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);

        if (await _userProvider.FindAsync(command.Login, command.Password, cancellationToken).ConfigureAwait(false) is not null)
        {
            throw new Exception("Введён неправильно логин/пароль");
        }

        var user = new Domain.Models.User(command.Login, command.Password);

        await _userProvider.AddAsync(user, cancellationToken).ConfigureAwait(false);

        return user.Id;
    }
}
