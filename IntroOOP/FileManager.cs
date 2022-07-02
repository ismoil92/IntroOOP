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
                if (command.Length > 0)
                {
                    Console.SetCursorPosition(currentLeft - 1, top);
                    Console.Write(" ");
                    Console.SetCursorPosition(currentLeft - 1, top);
                }
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (!string.IsNullOrEmpty(_command))
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
        DrawConsole(GetShortPath(currentDirectory), 0, 26, WIDTH, 3);
        Console.Write($"{command}");
    }

    /// <summary>
    /// Метод, для преобразования в командную строку для выполнение команд
    /// </summary>
    /// <param name="command">команда для консоли</param>
    static void ParseCommandString(string command)
    {
        string[] commands = command.ToLower().Split(' ');
        if (commands.Length > 0)
        {
            switch (commands[0])
            {
                case "cd": // переход на другую директорию
                    if (commands.Length>1)
                    {
                        if(Directory.Exists(commands[1]) && commands[1]!="..")
                        {
                            currentDirectory = commands[1];
                        }
                        else if (commands[1]=="..")
                        {
                            //Переход на уровень выше каталога.
                            DirectoryInfo dir = Directory.GetParent(currentDirectory);
                            currentDirectory = dir.ToString();
                        }
                    }
                    break;
                case "ls": // Пейджинг т.е. страничный режим
                    if(commands.Length>1 && Directory.Exists(commands[1]))
                    {
                        if(commands.Length>3 && commands[2]=="-p" && int.TryParse(commands[3], out int n))
                        {
                            DrawTree(new DirectoryInfo(commands[1]), n);
                        }
                        else
                        {
                            DrawTree(new DirectoryInfo(commands[1]), 1);
                        }
                    }
                    break;
                case "cp": //Копирование каталогов и файлов
                    if( commands.Length>2 && Directory.Exists(commands[1]))
                    {
                        if (Directory.Exists(commands[1]) && !Directory.Exists(commands[2]))
                        {
                            CopyDirectory(commands[1], commands[2]);
                        }
                    }
                    else if (commands.Length > 2 && File.Exists(commands[1]))
                    {
                        CopyFile(commands[1], commands[2]);
                    }
                    break;
            }
        }
        UpdateConsole();
    }

    /// <summary>
    /// Метод, для копирование папки
    /// </summary>
    /// <param name="sourcepathName">Путь копирование папки</param>
    /// <param name="destinationpathName">Путь целевого папок</param>
    static void CopyDirectory(string sourcepathName, string destinationpathName)
    {
        Directory.CreateDirectory(destinationpathName);
        foreach(string s1 in Directory.GetFiles(sourcepathName))
        {
            string s2 = destinationpathName + "\\" + Path.GetFileName(s1);
            File.Copy(s1, s2);
        }
        foreach(var d1 in Directory.GetDirectories(sourcepathName))
        {
            CopyDirectory(d1, destinationpathName + "\\" + Path.GetFileName(d1));
        }
    }

    /// <summary>
    /// Метод, для копирование файлов
    /// </summary>
    /// <param name="sourcePathName">Путь копирование файлов</param>
    /// <param name="destinationPathName">Путь целевого файла</param>
    static void CopyFile(string sourcePathName, string destinationPathName) => File.Copy(sourcePathName, Path.Combine(destinationPathName + "\\" + Path.GetFileName(sourcePathName)));


    /// <summary>
    /// Метод, для рисование дерево каталогов директорий и файлов
    /// </summary>
    /// <param name="dir">текущий путь каталогоа</param>
    /// <param name="page">номер страницы</param>
    static void DrawTree(DirectoryInfo dir, int page)
    {
        StringBuilder tree = new StringBuilder();
        GetTree(tree, dir, "", true);
        string[] lines = tree.ToString().Split('\n');
        File.WriteAllText(fileTree, tree.ToString());
        DrawWindow(0, 0, WIDTH, 18);
        (int currentLeft, int currentTop) = Console.GetCursorPosition();
        int pageLines = 16;
        int totalPages = (lines.Length + pageLines - 1) / pageLines;
        if(page>totalPages)
        {
            page = totalPages;
        }
        for (int i = (page - 1) * pageLines, counter = 0; i < (page * pageLines); i++, counter++)
        {
            if (lines.Length - 1 > i)
            {
                Console.SetCursorPosition(currentLeft + 1, currentTop + 1 + counter);
                Console.WriteLine(lines[i]);
            }
        }
        //footer
        string footer = $"╡ {page} of {totalPages} ╞";
        Console.SetCursorPosition(WIDTH / 2 - footer.Length / 2, 17);
        Console.Write(footer);

    }
    /// <summary>
    /// Метод, для получение дерево каталогов
    /// </summary>
    /// <param name="tree">дерево каталогов</param>
    /// <param name="directory">текущий каталог</param>
    /// <param name="indent">отступ от начального консольного экрана</param>
    /// <param name="lastDirectory">проверяет является ли последный директорий</param>
    static void GetTree(StringBuilder tree, DirectoryInfo directory, string indent, bool lastDirectory)
    {
        tree.Append(indent);
        if(lastDirectory)
        {
            tree.Append("└─");
            indent += "  ";
        }
        else
        {
            tree.Append("├─");
            indent += "│ ";
        }
        tree.Append($"{directory.Name}\n");
        DirectoryInfo[] directories = directory.GetDirectories();
        FileInfo[] files = directory.GetFiles();
        for(int i=0;i<files.Length;i++)
        {
            if(i==files.Length-1)
            {
                tree.Append($"{indent}└─{files[i].Name}\n");
            }
            else
            {
                tree.Append($"{indent}├─{files[i].Name}\n");
            }
        }
        for(int i=0;i<directories.Length;i++)
        {
            GetTree(tree, directories[i], indent, i == directories.Length - 1);
        }
    }
    #endregion
}
