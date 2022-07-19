using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;

public class ChangeDirectoryCommand : FileManagerCommand
{
    private readonly IUserInterface userInterface;
    private readonly FileManagerLogic fileManager;

    public ChangeDirectoryCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        this.userInterface = userInterface;
        this.fileManager = fileManager;
    }

    public override string Direction => "Изменение текущего каталога";

    public override void Execute(string[] args)
    {
        if(args.Length != 2 || !string.IsNullOrEmpty(args[1]))
        {
            userInterface.WriteLine("Для команды смены каталога необходимо указать один параметр -" +
                "целевой путь");
            return;
        }

        var dir_path = args[1];
        DirectoryInfo? directory;

        if(dir_path == "..")
        {
            directory = fileManager.CurrentDirectory.Parent;
            if (directory is null)
            {
                userInterface.WriteLine("Невозможно подняться выше по дереву каталогов");
                return;
            }
            else if (Path.IsPathRooted(dir_path))
                Path.Combine(fileManager.CurrentDirectory.FullName, dir_path);
            directory = new DirectoryInfo(dir_path);
            if(!directory.Exists)
            {
                userInterface.WriteLine($"Директория {directory} не существует");
                return;
            }
            fileManager.CurrentDirectory = directory;
            userInterface.WriteLine($"Текущая директория изменена на {directory.FullName}");
            Directory.SetCurrentDirectory(directory.FullName);
        }
    }
}