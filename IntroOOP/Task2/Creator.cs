using System.Collections;

namespace IntroOOP.Task2;

public class Creator
{

    /// <summary>
    /// Закрытый конструктор
    /// </summary>
    private Creator() { }


    /// <summary>
    /// Статическое поле хеш-таблица
    /// </summary>

    private static Hashtable hashtable = new Hashtable();


    /// <summary>
    /// Метод, для создание объектов BuildingNumber2 и запись в хеш-таблицу
    /// </summary>
    /// <param name="height">высота в доме</param>
    /// <param name="numbOfStorey">количество этажей в доме</param>
    /// <param name="numbOfFlat">количество квартир в доме</param>
    /// <param name="entrance">количество подъезда в доме</param>
    ///<returns>возвращает объект класса BuildingNumber2</returns>
    public static BuildingNumber2 CreateBuild(double height, int numbOfStorey, int numbOfFlat, int entrance)
    {
        BuildingNumber2 building = new(height, numbOfStorey, numbOfFlat, entrance);
        hashtable.Add(BuildingNumber2.UniqueID, building);
        return building;
    }


    /// <summary>
    /// Метод, для удаление объектов в хеш-таблице
    /// </summary>
    /// <param name="key">ключ для удаление объекта в хеш-таблице</param>
    /// <returns>возвращает true если объект в хеш-таблице удалён, false если ключ в хеш-таблице не найден для удаления</returns>
    public static bool RemoveBuild(int key)
    {
        if(hashtable.ContainsKey(key))
        {
            hashtable.Remove(key);
            return true;
        }
        return false;
    }


    /// <summary>
    /// Метод, для изменение значение ( объект дом) в хеш-таблице через ключ
    /// </summary>
    /// <param name="key">ключ для текущего объекта в хеш-таблице</param>
    /// <param name="building">новая значения (объект дом) для изменение по текущему ключа</param>
    public static void UpdateBuild(int key, BuildingNumber2 building)
    {
        if(hashtable.ContainsKey(key))
        {
            hashtable[key] = building;
        }
        return;
    }
}