using System.Collections.Generic;

namespace Enrollee.Domain.Models.Vacancy;

public class Faculty:BaseModel
{
    public string Name { get; private init; }
    public int ExternalId { get; private init; }
    public ICollection<Speciality> Specialities { get; private init; }
    public Faculty()
    {
        Specialities = new List<Speciality>();
    }
}