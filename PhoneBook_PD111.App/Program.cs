using PhoneBook_PD111.Lib.CLI;
using PhoneBook_PD111.Models.Phones;
using PhoneBook_PD111.Models.Phones.Number;
using PhoneBook_PD111.Models.Phones.Type;

namespace PhoneBook_PD111.App;

internal static class Program
{
    private static void Main()
    {
        var phoneTypes = new List<string> { "мобильный", "рабочий", "домашний" };
        
        CLI.ShowList(phoneTypes);
        var index = Convert.ToInt32(CLI.Input("Введите номер типа: "));
        var number = CLI.Input("Введите номер телефона: ");
        
        BasePhone phone1 = new Phone(new PhoneType(phoneTypes[index-1]), new EasyPhoneNumber(number));
        PrintPhone(phone1);

        var code = CLI.Input("Введите код телефона: ");
        var number2 = CLI.Input("Введите номер телефона: ");
        BasePhone phone2 = new Phone(new PhoneType(phoneTypes[index - 1]), new HardPhoneNumber(code, number2));
        PrintPhone(phone2);
    }

    static void PrintPhone(BasePhone phone)
    {
        CLI.ShowInfo(phone.ToString());
    }
}
