using IntroOOP.Commands.BaseCommand;
using System.Text;

namespace IntroOOP.Commands;

public class TextFileInformationCommand : FileManagerCommand
{
    #region FIELDS

    private readonly IUserInterface _userInterface;

    private readonly FileManagerLogic _fileManager;

    #endregion

    /// <summary>
    /// Конструктор с двумя параметрами
    /// </summary>
    /// <param name="userInterface">интерфейс пользователя</param>
    /// <param name="fileManager">логика файловой менеджера</param>
    public TextFileInformationCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        _fileManager = fileManager;
        _userInterface = userInterface;
    }

    /// <summary>
    /// Переопределенный свойства, содержимое о команд
    /// </summary>
    public override string Description => "Информация о текстовом файле";

    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        int countWords = 0;
        int countLines = 0;
        int countParagragh = 0;
        int countWordsNotSpace = 0;
        //int countSymbolSpace=0;    не нашёл как решить проблему
        if (File.Exists(args[1]))
        {
            using (FileStream fileStream = File.OpenRead(args[1]))
            {
               byte[] buffer = new byte[fileStream.Length];
               fileStream.Read(buffer, 0, buffer.Length);
                string textFromFile = Encoding.Default.GetString(buffer);
                countWords = textFromFile.Split(' ').Length;
                countLines = textFromFile.Split('\n').Length;
                countParagragh = textFromFile.Split('\t').Length;
                countWordsNotSpace = textFromFile.Split('-').Length;
                _userInterface.WriteLine($"Количество слов: {countWords}, количество строк: {countLines}, " +
                    $"количество абзацев: {countParagragh}, количество слов без пробелов: {countWordsNotSpace}");
            }
        }
    }
}