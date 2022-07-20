namespace IntroOOP.Commands.BaseCommand;

public abstract class FileManagerCommand
{
    /// <summary>
    /// Абстрактный свойство, сведение о команд
    /// </summary>
    public abstract string Description { get; }

    /// <summary>
    /// Абстрактный метод, для выполнение команд при вводе
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public abstract void Execute(string[] args);
}