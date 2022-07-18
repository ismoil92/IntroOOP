namespace IntroOOP.Task1;

public interface ICoder
{
    /// <summary>
    /// Метод, для шифрование строки
    /// </summary>
    /// <param name="input">строка для шифрование</param>
    /// <returns>возвращает шифрованную строку</returns>
    string Encode(string input);


    /// <summary>
    /// Метод, для дешифрование строки
    /// </summary>
    /// <param name="input">строка для дешифрование</param>
    /// <returns>возвращает дешифрованную строку</returns>
    string Decode(string input);
}