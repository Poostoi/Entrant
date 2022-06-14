namespace Enrollee.Domain.Models.AboutOfEntrant;

public class MaritalStatus: BaseModel
{
    public Family Family { get; private init; }
    public int? BrotherSister { get; private init; }
    public int? Children { get; private init; }
}