using IntroOOP.Commands.BaseCommand;

namespace IntroOOP;

public class FileManagerLogic
{
    private bool _CanWork = true;

    private readonly IUserInterface _userInterface;

    public DirectoryInfo CurrentDirectory { get; set; } = new("");

    public IReadOnlyDictionary<string, FileManagerConsole> Commands { get; }
}