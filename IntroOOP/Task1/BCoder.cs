namespace IntroOOP.Task1;

public class BCoder : ICoder
{
    #region FIELDS
    /// <summary>
    /// Массив символов алфавит нижним регистром
    /// </summary>
    char[] alphabetLower = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
    'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

    /// <summary>
    /// Массив символов алфавит верхним регистром
    /// </summary>
    char[] alphabetUpper = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O',
    'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
    #endregion

    #region METHODS
    /// <summary>
    /// Метод, для шифрование строк
    /// </summary>
    /// <param name="input">строка для шифрование</param>
    /// <returns>возвращает шифрованную строку</returns>
    public string Decode(string input)
    {
        char[] chars = input.ToCharArray();
        input = "";
        int j = 0;
        for(int i=0;i<chars.Length;i++)
        {
            if('A'<=chars[i] && chars[i]<='Z')
            {
                while(true)
                {
                    if(chars[i] == alphabetUpper[j])
                    {
                        if(j< alphabetUpper.Length/2)
                        {
                            input += (char)(alphabetUpper[alphabetUpper[alphabetUpper.Length - 1] - alphabetUpper[j]]);
                            break;
                        }
                        else if(j>= alphabetUpper.Length/2)
                        {
                            input += (char)(alphabetUpper[alphabetUpper[alphabetUpper.Length - 1] - alphabetUpper[j]]);
                            break;
                        }
                    }
                    j++;
                    if (j == alphabetUpper.Length)
                        break;
                }
                j = 0;
            }
            else if('a'<=chars[i] && chars[i]<='z')
            {
                while (true)
                {
                    if (chars[i] == alphabetLower[j])
                    {
                        if (j < alphabetUpper.Length / 2)
                        {
                            input += (char)(alphabetLower[alphabetLower[alphabetLower.Length - 1] - alphabetLower[j]]);
                            break;
                        }
                        else if (j >= alphabetUpper.Length / 2)
                        {
                            input += (char)(alphabetLower[alphabetLower[alphabetLower.Length - 1] - alphabetLower[j]]);
                            break;
                        }
                    }
                    j++;
                    if (j == alphabetLower.Length)
                        break;
                }
                j = 0;
            }
        }
        return input;
    }

    /// <summary>
    /// Метод, для дешифрование строк
    /// </summary>
    /// <param name="input">строка для дешифрование</param>
    /// <returns>возвращает дешифрованную строку</returns>
    public string Encode(string input)
    {
        char[] chars = input.ToCharArray();
        input = "";
        int j = 0;
        for(int i=0;i<chars.Length;i++)
        {
            if ('A' <= chars[i] && chars[i] <= 'Z')
            {
                while (true)
                {
                    if (chars[i] == alphabetUpper[j])
                    {
                        if (j < alphabetUpper.Length / 2)
                        {
                            input += (char)(alphabetUpper[alphabetUpper.Length - 1 - j]);
                            break;
                        }
                        else if (j >= alphabetUpper.Length / 2)
                        {
                            input += (char)(alphabetUpper[alphabetUpper.Length - 1 - j]);
                            break;
                        }
                    }
                    j++;
                    if (alphabetUpper.Length == j)
                        break;
                }
                j = 0;
            }
            else if ('a' <= chars[i] && chars[i] <= 'z')
            {
                while (true)
                {
                    if (chars[i] == alphabetLower[j])
                    {
                        if (j < alphabetLower.Length / 2)
                        {
                            input += (char)(alphabetLower[alphabetLower.Length - 1 - j]);
                            break;
                        }
                        else if (j >= alphabetLower.Length / 2)
                        {
                            input += (char)(alphabetLower[alphabetLower.Length - 1 - j]);
                            break;
                        }
                    }
                    j++;
                    if (alphabetLower.Length == j)
                        break;
                }
                j = 0;
            }
        }
        return input;
    }
    #endregion
}