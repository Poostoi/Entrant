using System;

namespace Enrollee.Domain.Models;


public class PassportData:BaseModel
{
    public int Series { get; private init; }
    public Sex Sex { get; private init; }
    public string Name { get; private init; }
    public string Surname { get; private init; }
    public string Patronomic { get; private init; }
    public Nationality Nationality { get; private init; }
    public bool ItIsGiven { get; private init; }
    public DateTime DateEnd { get; private init; }
    public DateTime DateModification { get; private set; }
    public Entrant Entrant { get; private set; }
}