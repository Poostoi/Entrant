using System;

namespace Enrollee.Domain.Models;

public interface IEntity
{
    Guid Id { get; }
    public  DateTime CreatedDate { get; }
    public  DateTime UpdatedDate { get; }
}
