using IntroOOP.Task1;
using IntroOOP.Task2;


SelectTasks();

/// <summary>
/// Метод, для выбора задачи
/// </summary>
static void SelectTasks()
{
    Console.WriteLine("====================Задача номер 1======================");
    Console.WriteLine("====================Задача номер 2======================");
    Console.Write("Выберите номер задач:");
    int numb = int.Parse(Console.ReadLine()!);
    switch(numb)
    {
        case 1:
            Task1();
            break;
        case 2:
            Task2();
            break;
        default:
            Console.WriteLine("Вы ввели некрроктный номер задач!");
            break;
    }
}

/// <summary>
/// Задача номер один
/// </summary>
static void Task1()
{
    Console.WriteLine("====================Задача номер 1======================");
    Console.WriteLine("========================================================");
    Console.WriteLine();
    ICoder acoder = new ACoder();
    ICoder bcoder = new BCoder();

    string text = "Hello World";
    string encoder = acoder.Encode(text);
    Console.WriteLine($"Класс ACoder Шифрований строка:{encoder}");
    string decoder = acoder.Decode(encoder);
    Console.WriteLine($"Класс ACoder Дешифрований строка:{decoder}");
    Console.WriteLine();
    string encoderB = bcoder.Encode("Hello");
    Console.WriteLine($"Класс BCoder Шифрованный строка:{encoderB}");
    string decoderB = bcoder.Decode(encoderB);
    Console.WriteLine($"Класс BCoder Дешифрованный строка:{decoderB}");
}


/// <summary>
/// Задача номер один
/// </summary>
static void Task2()
{
    Console.WriteLine("====================Задача номер 2======================");
    Console.WriteLine("========================================================");
    Console.WriteLine();

    Figure circle = new Circle("red", true, 2, 2, "Окружность", 2);
    Figure rectangle = new Rectangle("blue", false, 3, 3, "Прямоугольник", 4, 5);
    Figure square = new Square("black", true, 1, 1, "Квадрат", 4);

    circle.MoveVertical(2, Direction.UP);
    rectangle.MoveHorizontal(1, Direction.LEFT);
    square.MoveVertical(1, Direction.DOWN);

    Console.WriteLine(circle);
    Console.WriteLine(rectangle);
    Console.WriteLine(square);

    Console.WriteLine();

    Point circle1 = new Circle("red", true, 3, 4, "Окружность", 3);
    Point rectangle1 = new Rectangle("blue", false, 6, 7, "Прямоугольник", 2, 4);
    Point square1 = new Square("black", true, 2, 2, "Квадрат", 5);

    circle1.GetArea();
    circle1.GetPerimetr();
    rectangle1.GetArea();
    rectangle1.GetPerimetr();
    square1.GetArea();
    square1.GetArea();
    Console.WriteLine(circle1);
    Console.WriteLine(rectangle1);
    Console.WriteLine(square1);
}