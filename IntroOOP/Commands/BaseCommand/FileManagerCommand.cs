namespace IntroOOP.Commands.BaseCommand;

public abstract class FileManagerCommand
{
    public abstract string Direction { get; }

    public abstract void Execute(string[] args);
}