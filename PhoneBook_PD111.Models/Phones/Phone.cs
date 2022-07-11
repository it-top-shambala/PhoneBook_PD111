using PhoneBook_PD111.Models.Phones.Number;

namespace PhoneBook_PD111.Models.Phones;

public class Phone : BasePhone
{
    public Phone(ContactType type, BasePhoneNumber phoneNumber) : base(type, phoneNumber)
    {
    }
}
