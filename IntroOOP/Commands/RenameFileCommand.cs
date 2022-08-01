using IntroOOP.Commands.BaseCommand;
using System.Text;

namespace IntroOOP.Commands;

public class RenameFileCommand : FileManagerCommand
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
    public RenameFileCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        _userInterface=userInterface;
        _fileManager=fileManager;
    }


    /// <summary>
    /// Переопределенный свойства, содержимое о команде
    /// </summary>
    public override string Description => "Переименование файла";

    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        if (File.Exists(args[1]))
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach (var path in args[1].Trim().Split('\\'))
            {
                if (i < args[1].Trim().Split('\\').Length - 1)
                {
                    sb.Append(path + "\\");
                }
                i++;
            }
            sb.Append(args[2]);
            File.Move(args[1], sb.ToString());
            _userInterface.WriteLine("Файл переименован");
        }
        else
            _userInterface.WriteLine($"Файл {args[1]}, не существует!!");
    }
}