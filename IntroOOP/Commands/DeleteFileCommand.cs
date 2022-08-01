using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;

public class DeleteFileCommand : FileManagerCommand
{
    #region FIELDS

    private readonly IUserInterface _userInterface;
    private readonly FileManagerLogic _fileManager;

    #endregion

    /// <summary>
    /// Контруктор с двумя параметрами
    /// </summary>
    /// <param name="userInterface">интерфейс пользователя</param>
    /// <param name="fileManager">логика файлового менеджера</param>
    public DeleteFileCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        _userInterface=userInterface;
        _fileManager=fileManager;
    }

    /// <summary>
    /// Переопределенный свойство, содержимое о команд
    /// </summary>
    public override string Description => "Удаление файла";

    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        if(args.Length == 3 )
        {
            if(File.Exists(args[2]) && args[1]=="/p")
            {
                bool istrue = true;
                while(istrue)
                {
                    _userInterface.Write("Удалить Да[y/Y] или Нет[n/N]?:");
                    char symbol = char.Parse(Console.ReadLine()!);
                    switch(symbol)
                    {
                        case 'y':
                        case 'Y':
                            if (File.Exists(args[2]))
                            {
                                File.Delete(args[2]);
                                _userInterface.WriteLine("Файл удален!");
                                istrue = false;
                            }
                            else
                                _userInterface.WriteLine("Путь к файлу не существует");
                            break;
                        case 'n':
                        case 'N':
                            _userInterface.WriteLine("Файл не удален. Повторите попытку!");
                            break;
                        default:
                            _userInterface.WriteLine("Вы ввели неверную команду, введите y/Y или n/N");
                            break;
                    }
                }
            }
            else
            {
                _userInterface.WriteLine($"Файл:{args[2]}, не существует");
                return;
            }
        }
        else if(args.Length == 2)
        {
            if (File.Exists(args[1]))
            {
                File.Delete(args[1]);
                _userInterface.WriteLine("Файл удален!");
            }
            else
                _userInterface.WriteLine($"Файл:{args[1]}, не существует");
        }
    }
}