namespace PhoneBook_PD111.Models;

public abstract class ContactType
{
    protected string Type;

    protected ContactType(string type)
    {
        this.Type = type;
    }

    public override string ToString()
    {
        return Type;
    }
}
