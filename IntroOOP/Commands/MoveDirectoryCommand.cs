using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;

public class MoveDirectoryCommand : FileManagerCommand
{
    #region FIELDS

    private readonly IUserInterface _userInterface;

    private readonly FileManagerLogic _fileManagerLogic;

    #endregion


    /// <summary>
    /// Конструктор с двумя параметрами
    /// </summary>
    /// <param name="userInterface">интерфейс пользователя</param>
    /// <param name="fileManager">логика файлового менеджера</param>
    public MoveDirectoryCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        _userInterface = userInterface;
        _fileManagerLogic = fileManager;
    }



    /// <summary>
    /// Переопределенный свойства, содержимое о команд
    /// </summary>
    public override string Description => "Перемещение директории";


    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        if (Directory.Exists(args[1]) &&!Directory.Exists(args[2]))
        {
            Directory.Move(args[1], args[2]);
            _userInterface.WriteLine($"Папка {args[1]}, перемещена");
        }
        else
            _userInterface.WriteLine("Ошибка пути директорий");
    }
}