using IntroOOP.Task1;
using IntroOOP.Task2;


SelectTasks();

/// <summary>
/// Метод, для выбора задач
/// </summary>
static void SelectTasks()
{
    Console.WriteLine("=======================Задача номер 1=====================");
    Console.WriteLine("=======================Задача номер 2=====================");
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
            Console.WriteLine("Вы ввели некорректный номер");
            break;
    }
}




/// <summary>
/// Задача номер один
/// </summary>
static void Task1()
{
    Console.WriteLine("========================Задача номер 1 ======================");
    Console.WriteLine("=============================================================");
    Console.WriteLine();
    AccountBank account1 = new(111222333, 150000);
    AccountBank account2 = new(333222444, 200000);

    bool istrue1 = account1 == account2;
    bool istrue2 = account1 != account2;
    bool istrue3 = account1.Equals(account2);

    int hash1 = account1.GetHashCode();
    int hash2 = account2.GetHashCode();

    Console.WriteLine(account1);
    Console.WriteLine(account2);
}


/// <summary>
/// Задача номер два
/// </summary>
static void Task2()
{
    Console.WriteLine("========================Задача номер 2 ======================");
    Console.WriteLine("=============================================================");
    Console.WriteLine();

    Point rectangle = new Rectangle("red", true, 2, 2, 4, 5);
    Point circle = new Circle("green", false, 4, 2, 2);
    Point square = new Square("blue", true, 6, 4, 4);

    rectangle.MoveHorizontal(3, Direction.RIGHT);
    circle.MoveVertical(1, Direction.DOWN);
    square.MoveHorizontal(2, Direction.LEFT);

    rectangle.Area();
    rectangle.Perimetr();

    circle.Area();
    circle.Perimetr();

    square.Area();
    square.Perimetr();

    Console.WriteLine("===================Прямоугольник========================");
    Console.WriteLine(rectangle);

    Console.WriteLine();

    Console.WriteLine("===================Окружность===========================");
    Console.WriteLine(circle);

    Console.WriteLine();

    Console.WriteLine("===================Квадрат==============================");
    Console.WriteLine(square);
}