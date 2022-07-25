﻿using IntroOOP.Commands;
using IntroOOP.Commands.BaseCommand;

namespace IntroOOP;

public class FileManagerLogic
{
    #region FIELDS
    private bool _CanWork = true;

    private readonly IUserInterface _userInterface;
    #endregion

    #region PROPERTIES
    /// <summary>
    /// Свойство, текущий директорий
    /// </summary>
    public DirectoryInfo CurrentDirectory { get; set; } = new(@"C:\Users\User");

    /// <summary>
    /// Свойство, словарь список команд
    /// </summary>
    public IReadOnlyDictionary<string, FileManagerCommand> Commands { get; }
    #endregion

    /// <summary>
    /// Конструктор, с одним параметром
    /// </summary>
    /// <param name="userInterface">интерфейс пользователя</param>
    public FileManagerLogic(IUserInterface userInterface)
    {
        this._userInterface = userInterface;

        var listDircommand = new PrintDirectoryFilesCommand(userInterface, this);
        var helpcommand = new HelpCommand(userInterface, this);
        var quitcommand = new QuitCommand(this);

        Commands = new Dictionary<string, FileManagerCommand>
        {
            {"dir", listDircommand},
            {"listDir", listDircommand },
            {"drives", new ListDrivesCommand(userInterface) },
            {"help", helpcommand},
            {"?", helpcommand},
            {"cd", new ChangeDirectoryCommand(userInterface, this) },
            {"exit", quitcommand },
            {"quit", quitcommand },
            {"mkdir", new CreateDirectoryCommand(userInterface, this) }, //mkdir [path]
            {"echo", new CreateFileCommand(userInterface, this) },       //echo [text] > [fileName] 
            {"rd", new DeleteDirectoryCommand(userInterface, this) }     //rd [path] conf - conf - дает уведомдение о том удалить ли этот директорий или нет
        };
    }

    #region METHODS
    /// <summary>
    /// Метод, для запуска работы файлового менеджера
    /// </summary>
    public void Start()
    {
        _userInterface.WriteLine("Файловой менеджер 2.0");
        do
        {
            var input = _userInterface.ReadLine($"{CurrentDirectory.FullName}> ", false);
            var args = input.Split(' ');
            var command_name = args[0];
            if(!Commands.TryGetValue(command_name, out var command))
            {
                _userInterface.WriteLine($"Неизвестная команда {command}");
                _userInterface.WriteLine("Для справки введите команду help");
            }

            try
            {
                command!.Execute(args);
            }
            catch(Exception ex)
            {
                _userInterface.WriteLine($"При выполнение команды {command_name}, произошло ошибка");
                _userInterface.WriteLine(ex.Message);
            }

        } while (_CanWork);
        _userInterface.WriteLine("Файловой менеджер завершена!!!");
    }

    /// <summary>
    /// Метод, для завершение файлового менеджера
    /// </summary>
    public void Stop() => _CanWork = false;
    #endregion
}