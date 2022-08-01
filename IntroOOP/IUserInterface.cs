namespace IntroOOP;

public interface IUserInterface
{
    /// <summary>
    /// Метод, для вывода на консоль. Курсор переходят на следующую строку
    /// </summary>
    /// <param name="str">строка ввода</param>
    void WriteLine(string str);

    /// <summary>
    /// Метод, для вывода на консоль. Курсор не переходят на следующую строку
    /// </summary>
    /// <param name="str">строка ввода</param>
    void Write(string str);

    /// <summary>
    /// Метод, для ввода строки на консоли, т.е. при вводе с клавиатуры
    /// </summary>
    /// <param name="Prompt">подсказка для ввода строки в консоль</param>
    /// <param name="PromptNewLine">переход на новую строку</param>
    /// <returns></returns>
    string ReadLine(string? Prompt, bool PromptNewLine=true);

    /// <summary>
    /// Метод, для ввода строки на консоли для корвертации в числовое значение int,
    /// т.е. при вводе с клавиатуры
    /// </summary>
    /// <param name="Prompt">подсказка для ввода строки в консоль</param>
    /// <param name="PromptNewLine">переход на новую строку</param>
    /// <returns></returns>
    int ReadInt(string? Prompt, bool PromptNewLine=true);

    /// <summary>
    /// Метод, для ввода строки на консоли для конвертации в число с плавающим значением double,
    /// т.е. при вводе с клавиатуры
    /// </summary>
    /// <param name="Prompt">подсказка для ввода строки в консоль</param>
    /// <param name="PromptNewLine">переход на новую строку</param>
    /// <returns></returns>
    double ReadDouble(string? Prompt, bool PromptNewLine=true);
}