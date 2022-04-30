using System;
using System.Threading;
using System.Threading.Tasks;
using Enrollee.Application.Entities.User;
using Enrollee.Domain.Models;
using Enrollee.Application.Setting;

namespace Enrollee.Application.Services.User;

internal sealed class RegistrationService : IRegistrationService
{
    private readonly IAccountProvider _accountProvider;
    private readonly  ITokenProvider _tokenProvider;
    public RegistrationService(IAccountProvider accountProvider, ITokenProvider tokenProvider)
    {
        ArgumentNullException.ThrowIfNull(accountProvider);

        _accountProvider = accountProvider;
        _tokenProvider = tokenProvider;
    }

    public async Task<Token> HandleAsync(RegistrationCommand command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);

        if (await _accountProvider.FindAsync(command.Login, cancellationToken).ConfigureAwait(false) is not null)
        {
            throw new ArgumentException("Этот логин уже занят");
        }

        var account = new Account(command.Login, command.Password);

        await _accountProvider.AddAsync(account, cancellationToken).ConfigureAwait(false);
        
        return  _tokenProvider.CreateToken(account);
    }
}
