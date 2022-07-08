namespace IntroOOP.Task1;
public class Building
{
    #region FIELDS
    private static int uniqueID = 1;
    private double height;
    private int numberOfStoreys;
    private int numberOfFlats;
    private int entrances;
    #endregion


    /// <summary>
    /// Метод, для записи, уникального номера зданий
    /// </summary>
    public static void SetUniqueID()=> uniqueID++;

    /// <summary>
    /// Метод, для чтение, уникального номера зданий
    /// </summary>
    /// <returns>возвращает уникальный номер зданий</returns>
    public static int GetUniqueID() => uniqueID;






    /// <summary>
    /// Метод, для записи высота зданий
    /// </summary>
    /// <param name="height">высота</param>
    public void SetHeight(double height) => this.height = height;


    /// <summary>
    /// Метод, для чтение высота зданий
    /// </summary>
    /// <returns>возвращает высоту зданий</returns>
    public double GetHeight() => height;








    /// <summary>
    /// Метод, для записи этажности
    /// </summary>
    /// <param name="storeys">номер этажа</param>
    public void SetNumberOfStoreys(int storeys) => numberOfStoreys = storeys;

    /// <summary>
    /// Метод, для чтение этажности
    /// </summary>
    /// <returns>возвращает номер этажей</returns>
    public int GetNumberOfStoreys() => numberOfStoreys;







    /// <summary>
    /// Метод, для записи, количество квартир
    /// </summary>
    /// <param name="countFlats">количество квартир</param>
    public void SetNumberOfFlats(int countFlats)=> numberOfFlats = countFlats;


    /// <summary>
    /// Метод, для чтение, количество квартир
    /// </summary>
    /// <returns>возвращает количество квартир</returns>
    public int GetNumberOfFlats() => numberOfFlats;






    /// <summary>
    /// Метод, для записи подъездов
    /// </summary>
    /// <param name="entrances">количество подъездов</param>
    public void SetEntrances(int entrances) => this.entrances = entrances;

    /// <summary>
    /// Метод, для чтение, количество подъездов
    /// </summary>
    /// <returns>возвращает количество подъездов</returns>
    public int GetEntrances()=> entrances;


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
    public int FindNumberOfFlatsOnStoreys(double height, int countStoreys) => ((int)height / countStoreys)/countStoreys;


    public void Print() => Console.WriteLine($"Идентификатор:{uniqueID}, Высота:{height}, Количество этажей:{numberOfStoreys}  " +
        $"Количество квартир в одном подъезде:{numberOfFlats}, Количество подъезд:{entrances}");
}
