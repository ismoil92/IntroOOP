using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;

public class ListDrivesCommand : FileManagerCommand
{
    private readonly IUserInterface userInterface;

    /// <summary>
    /// Конструктор, с одним параметром
    /// </summary>
    /// <param name="userInterface">интерфейс пользователя</param>
    public ListDrivesCommand(IUserInterface userInterface)
    {
        this.userInterface = userInterface;
    }

    /// <summary>
    /// Переопределенный свойства, содержимое о команде
    /// </summary>
    public override string Description => "Вывод списка дисков в системе";

    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        var drivers = DriveInfo.GetDrives();
        userInterface.WriteLine($"В файловой системе существует дисков:{drivers.Length}");
        foreach (var drive in drivers)
            userInterface.WriteLine($"{drive.Name}");
    }
}