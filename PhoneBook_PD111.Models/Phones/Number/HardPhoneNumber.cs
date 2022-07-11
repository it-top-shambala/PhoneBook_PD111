namespace PhoneBook_PD111.Models.Phones.Number;

public class HardPhoneNumber : BasePhoneNumber
{
    public HardPhoneNumber(string code, string number)
    {
        Code = code;
        Number = number;
    }

    public string Code { get; set; }
    public string Number { get; set; }

    public override string ToString()
    {
        return $"{Code} {Number}";
    }
}
