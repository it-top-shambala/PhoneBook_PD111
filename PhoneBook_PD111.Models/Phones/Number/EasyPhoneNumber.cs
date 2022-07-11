namespace PhoneBook_PD111.Models.Phones.Number;

public class EasyPhoneNumber : BasePhoneNumber
{
    public EasyPhoneNumber(string number)
    {
        Number = number;
    }

    public string Number { get; set; }

    public override string ToString()
    {
        return Number;
    }
}
