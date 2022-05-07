using System;

namespace Enrollee.Domain.Models;

public class Role: IEntity
{
    public Role(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }
    public Guid Id { get; private init; }
    public string Name { get; private init; }
}