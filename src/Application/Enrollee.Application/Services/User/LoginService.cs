using System;
using System.Threading;
using System.Threading.Tasks;
using Enrollee.Application.Entities.User;

namespace Enrollee.Application.Services.User;

internal sealed class LoginService : ILoginService
{
    private readonly IAccountProvider _accountProvider;
    private readonly ITokenProvider _tokenProvider;

    public LoginService(IAccountProvider accountProvider, ITokenProvider tokenProvider)
    {
        ArgumentNullException.ThrowIfNull(accountProvider);

        _accountProvider = accountProvider;
        _tokenProvider = tokenProvider;
    }

    public async Task<Token> HandleAsync(LoginCommand command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);
        var account = await _accountProvider.FindAsync(command.Login, cancellationToken).ConfigureAwait(false);

        if (account is null || !account.Verify(command.Password))
        {
            throw new ArgumentException($"Неверный логин или пароль");
        }

        return _tokenProvider.CreateToken(account);
    }
}