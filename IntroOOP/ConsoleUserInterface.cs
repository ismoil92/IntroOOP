using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP
{
    internal class ConsoleUserInterface : IUserInterface
    {
        #region METHODS
        /// <summary>
        /// Метод, для вывода текста, на новую строку или в эту строку
        /// </summary>
        /// <param name="Promtp">строка</param>
        /// <param name="NewLine">переход на новую строку если true, false,не переход на новую строку</param>
        private void WritePromt(string? Promtp, bool NewLine)
        {
            if (Promtp is { Length: > 0 })
                if(NewLine)
                    WriteLine(Promtp);
                else
                    Write(Promtp);
        }

        /// <summary>
        /// Метод, парсить строку в вещественный число double
        /// </summary>
        /// <param name="Promtp">строка</param>
        /// <param name="NewLine">переход на новую строку если true, false,не переход на новую строку</param>
        /// <returns>возвращает вещественный число</returns>
        public double ReadDouble(string? Prompt, bool PromptNewLine = true)
        {
            bool success;
            double value;
            do
            {
                var input = Console.ReadLine();
                success = double.TryParse(input, out value);
                if (!success)
                    Console.WriteLine("Строка имела неверный формат");
            } while (!success);
            return value;
        }

        /// <summary>
        /// Метод, парсить строку в целое число, int
        /// </summary>
        /// <param name="Promtp">строка</param>
        /// <param name="NewLine">переход на новую строку если true, false,не переход на новую строку</param>
        /// <returns>возвращает целое число</returns>
        public int ReadInt(string? Prompt, bool PromptNewLine = true)
        {
            bool success;
            int value;
            do
            {
                var input = Console.ReadLine();
                success = int.TryParse(input, out value);
                if (!success)
                    Console.WriteLine("Строка имела неверный формат!");
            }while (!success);
            return value;
        }

        /// <summary>
        /// Метод, для ввода строки
        /// </summary>
        /// <param name="Promtp">строка</param>
        /// <param name="NewLine">переход на новую строку если true, false,не переход на новую строку</param>
        /// <returns>возвращает строку</returns>
        public string ReadLine(string? Prompt, bool PromptNewLine = true)
        {
            WritePromt(Prompt, PromptNewLine);
            return Console.ReadLine()!;
        }

        /// <summary>
        /// Метод, выводить строку с помощью метода Console.Write
        /// </summary>
        /// <param name="str">строка</param>
        public void Write(string str)
        {
            Console.Write(str);
        }

        /// <summary>
        /// Метод, выводить строку с помощью метода Console.WriteLine
        /// </summary>
        /// <param name="str">строка</param>
        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
        #endregion
    }
}
