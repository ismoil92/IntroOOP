using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;

public class SetAttributeFileCommand : FileManagerCommand
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
    public SetAttributeFileCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        _userInterface = userInterface;
        _fileManager = fileManager;
    }

    /// <summary>
    /// Переопределенный свойства, содержимое о команд
    /// </summary>
    public override string Description => "Изменение атрибута файла";


    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        switch (args[2])
        {
            case "ReadOnly":
            case "readOnly":
                File.SetAttributes(args[1], FileAttributes.ReadOnly);
                _userInterface.WriteLine($"Файл {args[1]}, изменен атрибут. Только чтение");
                break;
            case "hidden":
            case "Hidden":
                File.SetAttributes(args[1], FileAttributes.Hidden);
                _userInterface.WriteLine($"Файл {args[1]}, изменен атрибут. Скрытие");
                break;
            case "Archive":
            case "archive":
                File.SetAttributes(args[1], FileAttributes.Archive);
                _userInterface.WriteLine($"Файл {args[1]}, изменен атрибут. Добавлено в архив");
                break;
            default:
                _userInterface.WriteLine("Неправльный ввод команд");
                break;
        }
    }
}