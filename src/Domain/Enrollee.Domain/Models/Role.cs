using System;

namespace Enrollee.Domain.Models;

public class Role: IEntity
{
    public Role(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
        CreatedDate = DateOnly.FromDateTime(DateTime.Now);
        UpdatedDate = DateOnly.FromDateTime(DateTime.Now);
    }
    public Guid Id { get; private init; }
    public string Name { get; private init; }
    public DateOnly CreatedDate { get; private init; }
    public DateOnly UpdatedDate { get; init; }

}