﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Enrollee.Application.Entities.User;

namespace Enrollee.Application.Services.User;

internal sealed class RegistrationService : IRegistrationService
{
    private readonly IUserProvider _userProvider;

    public RegistrationService(IUserProvider userProvider)
    {
        ArgumentNullException.ThrowIfNull(userProvider);

        _userProvider = userProvider;
    }

    public async Task<Guid> HandleAsync(RegistrationCommand command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);

        if (await _userProvider.FindAsync(command.Login, cancellationToken).ConfigureAwait(false) is not null)
        {
            throw new ArgumentException("Этот логин уже занят");
        }

        var user = new Domain.Models.User(command.Login, BCrypt.Net.BCrypt.HashPassword(command.Password));

        await _userProvider.AddAsync(user, cancellationToken).ConfigureAwait(false);

        return user.Id;
    }
}
