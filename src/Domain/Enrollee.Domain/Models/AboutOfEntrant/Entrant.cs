using System;

namespace Enrollee.Domain.Models.AboutOfEntrant;

public class Entrant: BaseModel
{
    
    public Guid MaritalStatusId { get; set; }
    public MaritalStatus MaritalStatus { get; private init; }
    public Guid PassportDataId { get; set; }
    public PassportData PassportData { get; private init; }
    
    public Guid EducationId { get; set; }
    public Education Education { get; private init; }
    public Guid EntrantAddressId { get; set; }
    public EntrantAddress EntrantAddress { get; set; }
    public DateTime DataOfBirth { get; set; }
    public int PlaceIdBirth { get; set; }
    public Guid? VacancyId { get; private init; }
    public Vacancy.Vacancy Vacancy { get; private init; }
}