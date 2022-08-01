using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;

public class SearchToMaskCommand : FileManagerCommand
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
    public SearchToMaskCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        _fileManager=fileManager;
        _userInterface=userInterface;
    }

    /// <summary>
    /// Переопределенный свойства, содержимое о команд
    /// </summary>
    public override string Description => "Поиск по маскам";

    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        if (Directory.Exists(args[1]))
        {
            var files = Directory.GetFiles(args[1], $"{args[2]}.txt", SearchOption.AllDirectories);
            int count = 0;
            foreach (var file in files)
            {
                _userInterface.WriteLine(file);
                count++;
            }
            _userInterface.WriteLine($"Поиск по маске завершён. Количество масок:{count}, в этом директорий:{args[1]}");
        }
        else
            _userInterface.WriteLine("Путь к файлу не найден!!!");
    }
}