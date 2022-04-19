using System;

namespace Enrollee.Domain.Models;

public interface IEntity
{
    Guid Id { get; }
}
