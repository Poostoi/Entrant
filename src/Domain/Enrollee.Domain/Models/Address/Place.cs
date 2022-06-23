using System;

namespace Enrollee.Domain.Models;

public class Place: BaseModel
{
    public string Name { get; private init; }
    public Guid? DestrictId { get; private init; }
    public Destrict Destrict { get; private init; }
}