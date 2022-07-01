using System.Text;
using WindowsAPI;

namespace IntroOOP;

public static class FileManager
{
    #region FIELDS
    public static int WIDTH = 120;
    public static int HEIGHT = 30;
    public static string currentDirectory = Directory.GetCurrentDirectory();
    public const string fileTree = "tree.txt";
    public static string _command;
    #endregion

    #region METHODS
    /// <summary>
    /// Метод, для рисование консольного окна windows
    /// </summary>
    /// <param name="x">начальное координаты по оси х</param>
    /// <param name="y">начальное координаты по оси у</param>
    /// <param name="width">Ширина окна windows</param>
    /// <param name="height">Высота окна windows</param>
    public static void DrawWindow(int x, int y, int width, int height)
    {
        // header windows console
        Console.SetCursorPosition(x, y);
        Console.Write("╔");
        for(int i=0;i<width-2;i++)
        {
            Console.Write("═");
        }
        Console.Write("╗");


        //body windows console
        Console.SetCursorPosition(x, y + 1);
        for(int i=0;i<height-2;i++)
        {
            Console.Write("║");
            for(int j=x+1; j<x+width-1;j++)
            {
                Console.Write(" ");
            }
            Console.Write("║");
        }

        //footer windows console
        Console.Write("╚");
        for(int i=0;i<width-2;i++)
        {
            Console.Write("═");
        }
        Console.Write("╝");
        Console.SetCursorPosition(x, y);
    }
    /// <summary>
    /// Обновление консоли
    /// </summary>
    public static void UpdateConsole()
    {
        DrawConsole(GetShortPath(currentDirectory), 0, 26, WIDTH, 3);
        ProcessEnterCommand(WIDTH);
    }

    /// <summary>
    /// Метод, для сокращенный путь
    /// </summary>
    /// <param name="path">текущий путь каталогов и файлов</param>
    /// <returns>возвращает сокращенный вариант</returns>
    static string GetShortPath(string path)
    {
        StringBuilder stringBuilder = new StringBuilder((int)API.MAX_PATH);
        API.GetShortPathName(path, stringBuilder, API.MAX_PATH);
        return stringBuilder.ToString();
    }

    /// <summary>
    /// Метод, для обновление консольного экрана
    /// </summary>
    /// <param name="dir">Текущий путь</param>
    /// <param name="x">начальное координата по оси х</param>
    /// <param name="y">начальное координата по оси у</param>
    /// <param name="width">ширина экрана</param>
    /// <param name="height">высота экрана</param>
    public static void DrawConsole(string dir, int x, int y, int width, int height)
    {
        DrawWindow(x, y, width, height);
        Console.SetCursorPosition(x + 1, y + height / 2);
        Console.Write($"{dir}>");
    }
    
    
    /// <summary>
    /// Метод, для ввода команд с клавиатуры 
    /// </summary>
    /// <param name="width">ширина экрана</param>
    static void ProcessEnterCommand(int width)
    {
        (int left, int top) = Console.GetCursorPosition();
        StringBuilder command = new StringBuilder();
        ConsoleKeyInfo keyInfo;
        char key;
        do
        {
            keyInfo = Console.ReadKey();
            key = keyInfo.KeyChar;
            if(keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter &&
                keyInfo.Key != ConsoleKey.UpArrow && keyInfo.Key!= ConsoleKey.DownArrow &&
                keyInfo.Key != ConsoleKey.LeftArrow && keyInfo.Key!= ConsoleKey.RightArrow)
            {
                command.Append(key);
            }
            (int currentLeft, int currentTop) = Console.GetCursorPosition();
            if(currentLeft==width-2)
            {
                Console.SetCursorPosition(currentLeft - 1, top);
                Console.Write(" ");
                Console.SetCursorPosition(currentLeft - 1, top);
            }

            if(keyInfo.Key == ConsoleKey.UpArrow || keyInfo.Key == ConsoleKey.DownArrow ||
                keyInfo.Key == ConsoleKey.LeftArrow || keyInfo.Key == ConsoleKey.RightArrow)
            {
                Console.SetCursorPosition(currentLeft - 1, top);
                Console.Write(" ");
                Console.SetCursorPosition(currentLeft - 1, top);
                if(keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if(!string.IsNullOrEmpty(_command))
                    {
                        DrawConsole2(_command);
                    }
                }
            }

            if(keyInfo.Key == ConsoleKey.Backspace)
            {
                if(command.Length>0)
                {
                    command.Remove(command.Length - 1, 1);
                }
                if(currentLeft>=left)
                {
                    Console.SetCursorPosition(currentLeft, top);
                    Console.Write(" ");
                    Console.SetCursorPosition(currentLeft, top);
                }
                else
                {
                    command.Clear();
                    Console.SetCursorPosition(left, top);
                }
            }

        } while (keyInfo.Key != ConsoleKey.Enter);
        if(command.Length>0)
        {
            _command = command.ToString();
        }
        ParseCommandString(command.ToString());
    }

    /// <summary>
    /// Второй метод, для рисование консоли, при нажатие кнопку вверх, чтоб вернул предыдущую команду
    /// </summary>
    /// <param name="command">консольная команда</param>
    static void DrawConsole2(string command)
    {
        DrawConsole(GetShortPath(command), 0, 26, WIDTH, 3);
        Console.Write($"{command}>");
    }

    //static void ParseCommandString(string command)
    //{

    //}
    #endregion
}
