namespace IntroOOP;

class Program
{
    static void Main(string[] args)
    {
        ConfigurationConsole();
        Console.ReadLine();
    }

    static void ConfigurationConsole()
    {
        Console.Title = "FileManager";
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        FileManager.DrawWindow(0, 0, FileManager.WIDTH, 18);
        FileManager.DrawWindow(0, 18, FileManager.WIDTH, 8);
        FileManager.UpdateConsole();
    }
}