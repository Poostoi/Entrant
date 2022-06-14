namespace Enrollee.Domain.Models.User;

public class Role: BaseModel
{
    protected Role()
    {
        Name = null!;
    }
    public string Name { get; private init; }
    

}
