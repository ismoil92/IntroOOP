using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;

public class DeleteDirectoryCommand : FileManagerCommand
{
    #region FIELDS
    private readonly IUserInterface userInterface;

    private readonly FileManagerLogic fileManager;
    #endregion

    /// <summary>
    /// Контруктор с двумя параметрами
    /// </summary>
    /// <param name="userInterface">интерфейс пользователя</param>
    /// <param name="fileManager">логика файлового менеджера</param>
    public DeleteDirectoryCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        this.userInterface = userInterface;
        this.fileManager = fileManager;
    }

    /// <summary>
    /// Переопределенный свойство, содержимое о команд
    /// </summary>
    public override string Description => "Удаление директорий вместе содержимым";

    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        DirectoryInfo directory = new DirectoryInfo(args[1]);
        if(args.Length == 2)
        {
            if(directory.Exists)
            {
                directory.Delete(true);
                userInterface.WriteLine("Директорий удалена полностью!!");
                return;
            }
            else
            {
                userInterface.WriteLine($"Директорий {args[1]} не существует");
                return;
            }
        }
        else if(args.Length==3)
        {
            char symbol;
            if(directory.Exists && args[2]=="conf")
            {
                bool istrue = true;
                while (istrue)
                {
                    userInterface.Write("Удалить Да[y/Y] или Нет[n/N]?:");
                    symbol = char.Parse(Console.ReadLine()!);
                    switch (symbol)
                    {
                        case 'y':
                        case 'Y':
                            directory.Delete(true);
                            userInterface.WriteLine("Директорий удалена полностью");
                            istrue = false;
                            break;
                        case 'n':
                        case 'N':
                            userInterface.WriteLine("Директорий не удалена полностью. Повторите попытку");
                            break;
                        default:
                            userInterface.WriteLine("Вы ввели неправильное команду, нажмите y или n." +
                                "Повторите попытку");
                            break;
                    }
                }
            }
            else
                userInterface.WriteLine($"Директорий {args[1]} не существует");
        }
    }
}