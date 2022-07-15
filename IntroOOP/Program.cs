using IntroOOP.Task1;
using IntroOOP.Task2;



SelectTasks();

static void SelectTasks()
{
    Console.WriteLine("===================== Задача номер 1 =====================");
    Console.WriteLine("===================== Задача номер 2 =====================");
    Console.Write("Выберите номер задач:");
    int numb = int.Parse(Console.ReadLine()!);
    switch(numb)
    {
        case 1:
            Task1();
            break;
        case 2:
            Task2();
            break;
        default:
            Console.WriteLine("Вы ввели некорректный номер задач");
            break;
    }
}



/// <summary>
/// Задача номер 2
/// </summary>
static void Task2()
{
    Console.WriteLine("====================== Задача номер 2 =====================");
    Console.WriteLine("===========================================================");
    Console.WriteLine();
    ComplexNumber c1 = new(2, 3);
    ComplexNumber c2 = new(2, 3);
    Console.Write("Выберите одну из трёх операции (+, -, *):");
    char operation = char.Parse(Console.ReadLine()!);
    switch(operation)
    {
        case '+':
           var plus = c1 + c2;
            break;
        case '-':
            var minus = c1 - c2;
            break;
        case '*':
            var multiply = c1 * c2;
            break;
        default:
            Console.WriteLine("Выберите одну из трёх операции: +, -, *");
            break;
    }

    ///Сравнение двух комплексных чисел
    bool istrue1 = c1 == c2;
    bool istrue2 = c1 != c2;
    bool istrue3 = c1.Equals(c2);
}



/// <summary>
/// Задача номер 1
/// </summary>
static void Task1()
{
    Console.WriteLine("====================== Задача номер 1 =====================");
    Console.WriteLine("===========================================================");
    Console.WriteLine();
    Rational r1 = new (3, 4);
    Rational r2 = new (4, 5);
    Console.Write("Выберите одну из пяти операции (+, -, *, /, %):");
    char operation = char.Parse(Console.ReadLine()!);

    switch (operation)
    {
        case '+':
            /// сложение
            var plus1 = r1 + r2;
            var plus2 = r1 + 3;
            var plus3 = 3 + r2;
            break;
        case '-':
            /// вычитание 
            var minus1 = r1 - r2;
            var minus2 = 3 - r2;
            var minus3 = r1 - 3;
            break;
        case '*':
            ///умножение
            var multiply1 = r1 * r2;
            var multiply2 = 3 * r2;
            var multiply3 = r1 * 3;
            break;
        case '/':
            ///деление
            var devided1 = r1 / r2;
            var devided2 = r1 / 3;
            var devided3 = 3 / r2;
            break;
        case '%':
            //остаток от деления
            double procent = r1 % r2;
            double procent2 = r1 % 0.1;
            double procent3 = 1.5 % r2;
            break;
        default:
            Console.WriteLine("Нет такого знака!!!");
            break;
    }



    ///Инкремент Декремент
    r1++;
    r2++;
    r1--;
    r2--;


    ///Явная преобразование
    (int numerator, int denominator) = (((int, int))r1);
    (float numeratorfloat, float denominatorfloat) = (((float, float))r1);

    (int numeratorint, int denominatorint) = (((int, int))r2);
    (float numerator_float, float denominator_float) = (((float, float))r2);



    //Сравнение двух рациональных чисел
    bool _bool1 = r1 > r2;
    bool _bool2 = r1 >= r2;
    bool _bool3 = r1 < r2;
    bool _bool4 = r1 <= r2;
    bool _bool5 = r1 == r2;
    bool _bool6 = r1 != r2;
    bool _bool7 = r1.Equals(r2);
}

