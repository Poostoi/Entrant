using System;
using System.ComponentModel.DataAnnotations;

namespace Enrollee.Domain.Models;

public abstract class BaseModel:IEntity
{
    protected BaseModel()
    {
        Id = Guid.NewGuid();
        CreatedDate =DateTime.UtcNow;
        UpdatedDate = DateTime.UtcNow;
    }
    [Key]
    public Guid Id { get;private init; }
    public  DateTime CreatedDate { get; private init; }
    public  DateTime UpdatedDate { get; private init;}

}