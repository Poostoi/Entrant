using System;

namespace Enrollee.Domain.Models.AboutOfEntrant;

public class Entrant: BaseModel
{
    public MaritalStatus MaritalStatus { get; private init; }
    public PassportData PassportData { get; private init; }
    public Education Education { get; private init; }
    public DateTime DataOfBirth { get; set; }
    public int PlaceIdBirth { get; set; }
    public int? VacancyId { get; private init; }
    public Vacancy.Vacancy Vacancy { get; private init; }
}