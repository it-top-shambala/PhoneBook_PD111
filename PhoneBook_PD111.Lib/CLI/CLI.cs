namespace PhoneBook_PD111.Lib.CLI;

public static class CLI
{
    private static void ShowLine(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    private static void Show(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(message);
        Console.ResetColor();
    }

    public static void ShowInfo(string message)
    {
        ShowLine(message, ConsoleColor.Blue);
    }

    public static void ShowError(string message)
    {
        ShowLine(message, ConsoleColor.Red);
    }

    public static void ShowSuccess(string message)
    {
        ShowLine(message, ConsoleColor.Green);
    }

    public static string Input(string message)
    {
        Show(message, ConsoleColor.Yellow);
        return Console.ReadLine();
    }
}
