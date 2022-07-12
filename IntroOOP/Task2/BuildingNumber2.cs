namespace IntroOOP.Task2;

public class BuildingNumber2
{
    /// <summary>
    /// Статическое свойство, уникальный идентификатор
    /// </summary>
    public static int UniqueID { get; set; } = 0;

    /// <summary>
    /// Свойство, Высота дома
    /// </summary>
    public double Height { get; set; }

    /// <summary>
    /// Свойство, количество этажей в доме
    /// </summary>
    public int NumberOfStoreys { get; set; }

    /// <summary>
    /// Свойство, количество квартир в доме
    /// </summary>
    public int NumberOfFlat { get; set; }

    /// <summary>
    /// Свойство, Подъезды в доме
    /// </summary>
    public int Entrances { get; set; }


    public BuildingNumber2(double height, int numbOfStorey, int numbOfFlat, int entrances)
    {
        UniqueID++;
        Height = height;
        NumberOfStoreys = numbOfStorey;
        NumberOfFlat = numbOfFlat;
        Entrances = entrances;
    }

    /// <summary>
    /// Метод, для нахождение высоты в доме
    /// </summary>
    /// <param name="countStoreys">количество этажей</param>
    /// <param name="countFlat">количество квартир</param>
    /// <returns>возвращает высоту в доме</returns>
    public double FindHeight(int countStoreys, int countFlat) => countStoreys * countFlat;



    /// <summary>
    /// Метод, для нахождение количество этажей в доме
    /// </summary>
    /// <param name="height">высота</param>
    /// <param name="countFlat">колиество квартир</param>
    /// <returns>возвращает количество этажей в доме</returns>
    public int FindNumberOfStoreys(double height, int countFlat) => (int)height / countFlat;




    /// <summary>
    /// Метод, для нахождение количество квартир в доме
    /// </summary>
    /// <param name="height">высота</param>
    /// <param name="countStoreys">количество этажей</param>
    /// <returns>возвращает количество квартир в доме</returns>
    public int FindNumberOfFlatsOnBuilding(double height, int countStoreys) => (int)height / countStoreys;



    /// <summary>
    /// Метод, для нахождение количество квартир на этажей
    /// </summary>
    /// <param name="height">высота</param>
    /// <param name="countStoreys">количество этажей</param>
    /// <returns>возвращает количество квартир на этажей</returns>
    public int FindNumberOfFlatsOnStoreys(double height, int countStoreys) => ((int)height / countStoreys) / countStoreys;


    /// <summary>
    /// Метод, для вывода информации о зданий
    /// </summary>
    public void Print() => Console.WriteLine($"Идентификатор:{UniqueID}, Высота:{Height}, Количество этажей:{NumberOfStoreys}  " +
        $"Количество квартир в одном подъезде:{NumberOfFlat}, Количество подъезд:{Entrances}");
}
