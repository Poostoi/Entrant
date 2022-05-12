using System;

namespace Enrollee.Domain.Models;

public class Role: BaseModel
{
    protected Role()
    {
        Name = null!;
    }
    public string Name { get; private init; }
    

}