using System;

namespace Enrollee.Domain.Models;

public class Entrant: BaseModel
{
    public MaritalStatus MaritalStatus { get; private init; }
    public PassportData PassportData { get; private init; }
    public Education Education { get; private init; }
    public DateTime DataOfBirth { get; set; }
    public int PlaceIdBirth { get; set; }
}