using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;

public class TextFileInformationCommand : FileManagerCommand
{
    #region FIELDS

    private readonly IUserInterface _userInterface;
    private readonly FileManagerLogic _fileManager;

    #endregion

    /// <summary>
    /// Конструктор с двумя параметрами
    /// </summary>
    /// <param name="userInterface">интерфейс пользователя</param>
    /// <param name="fileManager">логика файловой менеджера</param>
    public TextFileInformationCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        _fileManager = fileManager;
        _userInterface = userInterface;
    }

    /// <summary>
    /// Переопределенный свойства, содержимое о команд
    /// </summary>
    public override string Description => "Информация о текстовых файла";

    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        
    }
}