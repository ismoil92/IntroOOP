using IntroOOP;


Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;

Console.Title = "Файловой менеджер 2.0";

var console_user = new ConsoleUserInterface();

FileManagerLogic FileManager = new FileManagerLogic(console_user);

FileManager.Start();

