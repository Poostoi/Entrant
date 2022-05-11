using System;

namespace Enrollee.Domain.Models;

public interface IEntity
{
    Guid Id { get; }
    public  DateOnly CreatedDate { get; }
    public  DateOnly UpdatedDate { get; }
}
