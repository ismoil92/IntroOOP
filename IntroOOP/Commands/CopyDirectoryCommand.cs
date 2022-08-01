using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;

public class CopyDirectoryCommand : FileManagerCommand
{
    #region FIELDS

    private readonly IUserInterface _userInterface;

    private readonly FileManagerLogic _fileManager;

    #endregion

    /// <summary>
    /// Конструктор с двумя параметрами
    /// </summary>
    /// <param name="userInterface">интерфейс пользователя</param>
    /// <param name="fileManager">логика файлового менеджера</param>
    public CopyDirectoryCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        _fileManager = fileManager;
        _userInterface = userInterface;
    }

    /// <summary>
    /// Переопределенный свойства, содержимое о команд
    /// </summary>
    public override string Description => "Копировать папку";


    #region METHODS
    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        if (Directory.Exists(args[1]) && !Directory.Exists(args[2]))
        {
            CopyDirectory(args[1], args[2]);
            _userInterface.WriteLine("Папка скопирована");
        }
        else
        {
            _userInterface.WriteLine("Ошибка пути папки!");
        }
    }

    /// <summary>
    /// Метод, для копирование директорий
    /// </summary>
    /// <param name="sourceDirectoryName">исходный путь директорий</param>
    /// <param name="destinationDirectoryName">Путь целевого директорий</param>
    private void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName)
    {
        Directory.CreateDirectory(destinationDirectoryName);
        foreach(var file in Directory.GetFiles(sourceDirectoryName))
        {
            string dest = destinationDirectoryName+"\\"+Path.GetFileName(file);
            File.Copy(file, dest);
        }
        foreach(var dir in Directory.GetDirectories(sourceDirectoryName))
        {
            CopyDirectory(dir, destinationDirectoryName + "\\" + Path.GetFileName(dir));
        }
    }
    #endregion
}