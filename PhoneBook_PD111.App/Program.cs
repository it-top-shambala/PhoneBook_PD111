using PhoneBook_PD111.Models;
using PhoneBook_PD111.Lib.CLI;

namespace PhoneBook_PD111.App;

internal static class Program
{
    private static void Main()
    {
        var exit = false;

        var persons = new List<Person>();

        do
        {
            ShowMenu();

            var select = CLI.Input("Введите номер: ");
            switch (select)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    CLI.ShowError("Неправильный ввод");
                    break;
            }
        } while (!exit);

        CLI.ShowInfo("До свидания...");
    }

    private static void ShowMenu()
    {
        CLI.ShowInfo("Режимы работы:");
        CLI.ShowInfo("1. Добавить запись");
        CLI.ShowInfo("2. Удалить запись");
        CLI.ShowInfo("3. Показать все записи");
        CLI.ShowInfo("0. Выйти");
    }
}
