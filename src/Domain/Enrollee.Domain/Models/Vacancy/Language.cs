using System.Collections.Generic;

namespace Enrollee.Domain.Models.Vacancy;

public class Language:BaseModel
{
    public string Name { get; private init; }
    public int ExternalId { get; private init; }
    public ICollection<Vacancy> Vacancies { get; private init; }
    public Language()
    {
        Vacancies = new List<Vacancy>();
    }
}