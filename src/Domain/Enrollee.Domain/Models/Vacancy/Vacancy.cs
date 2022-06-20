using System.Collections.Generic;
using Enrollee.Domain.Models.AboutOfEntrant;

namespace Enrollee.Domain.Models.Vacancy;

public class Vacancy:BaseModel
{
    public Forma Forma { get; private init; }
    public int ExternalId { get; private init; }
    public int VacancyId { get; private init; }
    public int? SpecialityId { get; private init; }
    public Speciality Speciality { get; private init; }
    public int? LanguageId { get; private init; }
    public Language Language { get; private init; }
    public ICollection<Entrant> Entrants { get; private init; }
    public Vacancy()
    {
        Entrants = new List<Entrant>();
    }
}