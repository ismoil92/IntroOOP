using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;

public class PrintDirectoryFilesCommand : FileManagerCommand
{
    #region FIELDS
    private readonly IUserInterface userInterface;

    private readonly FileManagerLogic fileManager;
    #endregion

    /// <summary>
    /// Конструктор с двумя параметрами
    /// </summary>
    /// <param name="userInterface">интерфейс пользователя</param>
    /// <param name="fileManager">логика файлового менеджера</param>
    public PrintDirectoryFilesCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        this.userInterface = userInterface;
        this.fileManager = fileManager;
    }

    /// <summary>
    /// Переопределенный свойства, содержимое о команде
    /// </summary>
    public override string Description => "Вывод содержимого директории";

    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        var directory = fileManager.CurrentDirectory;
        userInterface.WriteLine($"Содержимое директорий {directory}:");
        var dir_count = 0;
        foreach(var direct in directory.EnumerateDirectories())
        {
            userInterface.WriteLine($"    d    {direct.Name}");
            dir_count++;
        }
        var file_count = 0;
        long file_length = 0;
        foreach(var file in directory.EnumerateFiles())
        {
            userInterface.WriteLine($"    f    {file.Name}\t{file.Length}");
            file_count++;
            file_length+=file.Length;
        }
        userInterface.WriteLine("");
        userInterface.WriteLine($"Директорий:{dir_count}, файлы:{file_count}, количество {file_length} байт");
    }
}