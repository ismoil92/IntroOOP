using IntroOOP.Task1;

Task1();




static void Task1()
{
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


