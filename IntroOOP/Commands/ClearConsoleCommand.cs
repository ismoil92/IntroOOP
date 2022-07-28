using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;

public class ClearConsoleCommand : FileManagerCommand
{
    #region FIELD
    private readonly FileManagerLogic _fileManager;
    #endregion

    /// <summary>
    /// Контруктор с одним параметром 
    /// </summary>
    /// <param name="fileManager">логика файлового менеджера</param>
    public ClearConsoleCommand(FileManagerLogic fileManager)
    {
        _fileManager = fileManager;
    }

    /// <summary>
    /// Переопределенный свойства, содержимое о команд
    /// </summary>
    public override string Description => "Очистка экрана";

    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        Console.Clear();
    }
}