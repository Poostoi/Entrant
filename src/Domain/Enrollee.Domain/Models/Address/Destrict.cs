using System.Collections.Generic;

namespace Enrollee.Domain.Models;

public class Destrict: BaseModel
{
    public string Name { get; private init; }
    public int? RegionId { get; private init; }
    public Region Region { get; private init; }
    public ICollection<Place> Places { get; private set; }
    public Destrict()
    {
        Places = new List<Place>();
    }
}