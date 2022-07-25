using IntroOOP.Commands.BaseCommand;
using System.Text;

namespace IntroOOP.Commands;

public class CreateFileCommand : FileManagerCommand
{
    #region FIELDS
    private readonly IUserInterface userInterface;

    private readonly FileManagerLogic fileManager;
    #endregion

    /// <summary>
    /// Конструктор с двумя параметрами
    /// </summary>
    /// <param name="userInterface">интерфейс пользователя</param>
    /// <param name="fileManager">логика файлового менеджера</param>
    public CreateFileCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        this.userInterface = userInterface;
        this.fileManager = fileManager;
    }

    /// <summary>
    /// Переодределенный свойство, содержимое о команде
    /// </summary>
    public override string Description => "Создание нового файла";

    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        StringBuilder stringBuilder = new StringBuilder();
        for(int i = 0; i < args.Length; i++)
            stringBuilder.Append(args[i]+" ");
        var commands = stringBuilder.ToString();
        commands.Trim();
        stringBuilder.Clear();
        string[] _commands = commands!.Split('>');
        string[] beforeCommand = _commands[0].Trim().Split(' ');
        string[] afterCommand = _commands[1].Trim().Split(' ');
        if(afterCommand.Length==1)
        {
            userInterface.WriteLine("Имя файла не введено");
            return;
        }
        if (beforeCommand[0]=="echo" && beforeCommand.Length>1 && afterCommand.Length==1)
        {
            for(int i=1;i<beforeCommand.Length;i++)
            {
                stringBuilder.Append(beforeCommand[i]+" ");
            }
            if (!File.Exists(fileManager.CurrentDirectory + "\\" + afterCommand[0]))
            {
                using (FileStream fileStream = new FileStream(fileManager.CurrentDirectory + "\\" + afterCommand[0], FileMode.CreateNew))
                {
                    byte[] bytes = Encoding.Default.GetBytes(stringBuilder.ToString());
                    fileStream.Write(bytes, 0, bytes.Length);
                }
            }
            else
                userInterface.WriteLine($"Файл с именем {afterCommand[0]}, уже создан");
        }
        else if(beforeCommand[0]=="echo" && beforeCommand.Length==1 && afterCommand.Length==1)
        {
            if (!File.Exists(fileManager.CurrentDirectory + "\\" + afterCommand[0]))
            {
                using (FileStream fileStream = new FileStream(fileManager.CurrentDirectory + "\\" + afterCommand[0], FileMode.CreateNew))
                {
                    byte[] bytes = Encoding.Default.GetBytes(stringBuilder.ToString());
                    fileStream.Write(bytes, 0, bytes.Length);
                }
            }
            else
                userInterface.WriteLine($"Файл с именем {afterCommand[0]}, уже создан");
        }
    }
}