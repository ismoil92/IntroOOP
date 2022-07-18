namespace IntroOOP.Task1;

public class ACoder : ICoder
{
    /// <summary>
    /// Метод, для дешифрования строки
    /// </summary>
    /// <param name="input">строка для дешифрования</param>
    /// <returns>возвращает дешифрованную строку</returns>
    public string Decode(string input)
    {
        char[] chars = input.ToCharArray();
        input = "";
        for(int i = 0; i < chars.Length; i++)
        {
            input += (char)(chars[i] - 1);
        }
        return input;
    }


    /// <summary>
    /// Метод, для шифрования строки
    /// </summary>
    /// <param name="input">строка для шифрования</param>
    /// <returns>возвращает шифрованную строку</returns>
    public string Encode(string input)
    {
        char[] chars = input.ToCharArray();
        input = "";
        for (int i = 0; i < chars.Length; i++)
        {
            input += (char)(chars[i] + 1);
        }
        return input;
    }
}