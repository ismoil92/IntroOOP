using IntroOOP.Task1;
using IntroOOP.Task2;
using CreatorAndBuildings.Utilities;





SelectTasks();
/// <summary>
/// Метод, для выбора задач
/// </summary>
static void SelectTasks()
{
    Console.WriteLine("==================Задача номер 1=======================");
    Console.WriteLine("==================Задача номер 2=======================");
    Console.WriteLine("==================Задача номер 3=======================");
    Console.Write("Выберите задачу от, 1-3:");
    int numb =int.Parse(Console.ReadLine()!);
    switch(numb)
    {
        case 1:
            Task1();
            break;
        case 2:
            Task2();
            break;
        case 3:
            Task3();
            break;
        default:
            Console.WriteLine("Выберите задача в диапазоне 1-3.");
            break;
    }
}

/// <summary>
/// Задача номер 3
/// </summary>
static void Task3()
{
    Console.WriteLine("=================Задача номер 3===================");
    Console.WriteLine("==================================================");
    Console.WriteLine();

    BuildingTask3 building1 = CreatorTask3.CreateBuild(12, 4, 8, 2);
    BuildingTask3 building2 = CreatorTask3.CreateBuild(15, 5, 10, 3);
    BuildingTask3 building3 = CreatorTask3.CreateBuild(16, 6, 11, 4);
    BuildingTask3 building4 = CreatorTask3.CreateBuild(17, 7, 9, 5);

    CreatorTask3.RemoveBuild(3);

    CreatorTask3.UpdateBuild(4, new(12, 3, 4, 5));
    BuildingTask3 building5 = CreatorTask3.CreateBuild(17, 7, 9, 5);
}


/// <summary>
/// Задача номер 2
/// </summary>
static void Task2()
{
    Console.WriteLine("=================Задача номер 2===================");
    Console.WriteLine("==================================================");
    Console.WriteLine();
    BuildingNumber2 building1 = Creator.CreateBuild(12, 4, 8, 2);
    BuildingNumber2 building2 = Creator.CreateBuild(15, 5, 10, 3);
    BuildingNumber2 building3 = Creator.CreateBuild(16, 6, 11, 4);
    BuildingNumber2 building4 = Creator.CreateBuild(17, 7, 9, 5);

    Creator.RemoveBuild(3);

    Creator.UpdateBuild(4, new(12, 3, 4, 5));
    BuildingNumber2 building5 = Creator.CreateBuild(17, 7, 9, 5);
}





/// <summary>
/// Задача номер 1
/// </summary>
static void Task1()
{

    Console.WriteLine("=================Задача номер 1===================");
    Console.WriteLine("==================================================");
    Console.WriteLine();

    ///building 1
    Building building1 = new();

    building1.SetEntrances(2);
    building1.SetHeight(12);
    building1.SetNumberOfStoreys(3);

    int numberflatBuilding = building1.FindNumberOfFlatsOnBuilding(building1.GetHeight(), building1.GetNumberOfStoreys());
    int numberflatOnStoreys = building1.FindNumberOfFlatsOnBuilding(building1.GetHeight(), building1.GetNumberOfStoreys());

    building1.SetNumberOfFlats(numberflatBuilding);

    building1.Print();
    Console.WriteLine($"Количество квартир в одном этажей:{numberflatOnStoreys}");


    Console.WriteLine();

    ///building2

    Building building2 = new();

    building2.SetEntrances(3);
    building2.SetNumberOfFlats(3);
    building2.SetNumberOfStoreys(4);
    Building.SetUniqueID();

    double height = building1.FindHeight(building2.GetNumberOfStoreys(), building2.GetNumberOfFlats());

    building2.SetHeight(height);

    building2.Print();
    Console.WriteLine();





    ///building3
    Building building3 = new();

    building3.SetEntrances(4);
    building3.SetNumberOfFlats(3);
    building3.SetHeight(15);
    Building.SetUniqueID();

    int storeys = building3.FindNumberOfStoreys(building3.GetHeight(), building3.GetNumberOfFlats());

    building3.SetNumberOfStoreys(storeys);

    building3.Print();
    Console.WriteLine();
}


