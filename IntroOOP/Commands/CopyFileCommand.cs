using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;

public class CopyFileCommand : FileManagerCommand
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
    public CopyFileCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        _userInterface = userInterface;
        _fileManager = fileManager;
    }

    
    /// <summary>
    /// Переопределенный свойства, содержимое о команд
    /// </summary>
    public override string Description => "Копирование файла";


    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        if (File.Exists(args[1]) && !File.Exists(args[2]))
        {
            File.Copy(args[1], args[2]);
            _userInterface.WriteLine("Файл скопирован");
        }
        else
            _userInterface.WriteLine("Ошибка пути файла!!!");
    }
}