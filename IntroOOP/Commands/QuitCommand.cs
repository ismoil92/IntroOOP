using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;

public class QuitCommand : FileManagerCommand
{
    private readonly FileManagerLogic fileManager;

    /// <summary>
    /// Конструктор с одним параметрами
    /// </summary>
    /// <param name="fileManager">логика файлового менеджера</param>
    public QuitCommand(FileManagerLogic fileManager)
    {
        this.fileManager = fileManager;
    }

    /// <summary>
    /// Переопределенный свойство, содержимое о команде
    /// </summary>
    public override string Description => "Выход";

    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        fileManager.Stop();
    }
}