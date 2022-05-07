using System;
using System.Threading;
using System.Threading.Tasks;
using Enrollee.Application.Entities.User;
using Enrollee.Domain.Models;

namespace Enrollee.Application.Services.User;

public class AddRoleService : IAddRoleService
{
    private readonly IRoleProvider _roleProvider;

    public AddRoleService(IRoleProvider roleProvider)
    {
        ArgumentNullException.ThrowIfNull(roleProvider);

        _roleProvider = roleProvider;
    }

    public async Task<string> HandleAsync(RoleCommand command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);

        if (await _roleProvider.FindAsync(command.Name, cancellationToken).ConfigureAwait(false) is not null)
        {
            throw new ArgumentException("Роль с таким именем существует");
        }

        var role = new Role(command.Name);

        await _roleProvider.AddAsync(role, cancellationToken).ConfigureAwait(false);

        return role.Name;
    }
}