namespace Enrollee.Domain.Models.AboutOfEntrant;

public class Education:BaseModel
{
    
    public string TypeEducationalInstitution { get; private init;}
    public string CharacterEducation { get; private init;}
    public int PlaceIdEducation { get; private init;}
    public Entrant Entrant { get; private init; }
}