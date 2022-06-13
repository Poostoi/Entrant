using System.Collections.Generic;

namespace Enrollee.Domain.Models;

public class Region: BaseModel
{
    public string Name { get; private init; }
    public int? CountryId { get; private init; }
    public Country Country { get; private init; }
    public ICollection<Destrict> Destricts { get; private set; }
    public Region()
    {
        Destricts = new List<Destrict>();
    }
}