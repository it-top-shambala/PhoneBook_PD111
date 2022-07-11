using PhoneBook_PD111.Models.Phones.Number;

namespace PhoneBook_PD111.Models.Phones;

public abstract class BasePhone
{
    protected ContactType Type;
    protected BasePhoneNumber PhoneNumber;

    protected BasePhone(ContactType type, BasePhoneNumber phoneNumber)
    {
        this.Type = type;
        this.PhoneNumber = phoneNumber;
    }

    public override string ToString()
    {
        return $"{Type.ToString()}, {PhoneNumber.ToString()}";
    }
}
