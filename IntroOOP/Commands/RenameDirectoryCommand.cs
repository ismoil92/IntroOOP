using IntroOOP.Commands.BaseCommand;
using System.Text;

namespace IntroOOP.Commands;

public class RenameDirectoryCommand : FileManagerCommand
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
    public RenameDirectoryCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        _userInterface = userInterface;
        _fileManager = fileManager;
    }

    /// <summary>
    /// Переопределенный свойства, содержимое о команд
    /// </summary>
    public override string Description => "Переименование папки";

    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        if (Directory.Exists(args[1]))
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();
            foreach(var path in args[1].Trim().Split('\\'))
            {
                if(i< args[1].Trim().Split('\\').Length-1)
                {
                    sb.Append(path+"\\");
                }
                i++;
            }
            sb.Append(args[2]);
            Directory.Move(args[1], sb.ToString());
            _userInterface.WriteLine("Папка переименована ");
        }
        else
            _userInterface.WriteLine($"Директорий {args[1]}, пуста!!");
    }
}