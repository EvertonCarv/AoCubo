// See https://aka.ms/new-console-template for more information
public static class ConsoleExtensions
{
    public static string ReadWithOffset()
    {
        Console.Write(" ");
        return Console.ReadLine();
    }
}