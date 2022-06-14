using Enrollee.Domain.Models.AboutOfEntrant;

namespace Enrollee.Domain.Models;

public class EntrantAddress: BaseModel
{
    public string Street { get; private init; }
    public bool IsApartament { get; private init; }
    public bool IsHostel { get; private init; }
    public int NumberHome { get; private init; }
    public int? Floor { get; private init; }
    public int? NumberApartament { get; private init; }
    public int? HomeTelethone { get; private init; }
    public Country Country { get; private init; }
    public Entrant Entrant { get; private init; }
}