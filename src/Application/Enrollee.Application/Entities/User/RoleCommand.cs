using System;
using Enrollee.Domain.Models;

namespace Enrollee.Application.Entities.User;

public class RoleCommand
{
    public RoleCommand(string name)
    {
        ArgumentNullException.ThrowIfNull(name);

        Name = name;
    }

    public string Name { get; private set; }
}