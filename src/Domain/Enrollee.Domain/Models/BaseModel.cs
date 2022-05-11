using System;

namespace Enrollee.Domain.Models;

public abstract class BaseModel:IEntity
{
    protected BaseModel()
    {
        Id = Guid.NewGuid();
        CreatedDate = DateOnly.FromDateTime(DateTime.Now);
        UpdatedDate = DateOnly.FromDateTime(DateTime.Now);
    }
    public Guid Id { get; }
    public  DateOnly CreatedDate { get; }
    public  DateOnly UpdatedDate { get; }
}