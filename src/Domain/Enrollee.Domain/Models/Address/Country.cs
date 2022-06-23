using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Enrollee.Domain.Models;

public class Country: BaseModel
{
    public string Name { get; private init; }
    public EntrantAddress EntrantAddress { get; private init; }
    public ICollection<Region> Regions { get; private set; }
    public Country()
    {
        Regions = new List<Region>();
    }
}