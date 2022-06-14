using System.Collections.Generic;

namespace Enrollee.Domain.Models.Vacancy;

public class Speciality:BaseModel
{
    public string Name { get; private init; }
    public int ExternalId { get; private init; }
    public ICollection<Vacancy> Vacancies { get; private init; }
    public Speciality()
    {
        Vacancies = new List<Vacancy>();
    }
    public int? FacultyId { get; private init; }
    public Faculty Faculty { get; private init; }
    
}