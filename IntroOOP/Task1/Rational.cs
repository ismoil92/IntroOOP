namespace IntroOOP.Task1;

public class Rational
{
    private double _numerator; // числитель
    private double _denominator; // знаменатель

    public Rational(double numerator, double denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }



    /// <summary>
    /// Перегрузка оператора == для сравнение двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональные числа</param>
    /// <param name="r2">второй рациональные числа</param>
    /// <returns>возвращает true, если они равны, false, если не равны</returns>
    public static bool operator == (Rational r1, Rational r2)
    {
        return Rational.Fraction(r1)==Rational.Fraction(r2);
    }



    /// <summary>
    /// Перегрузка оператора != для сравнение двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональные числа</param>
    /// <param name="r2">второй рациональные числа</param>
    /// <returns>возвращает true, если они не равны, false, если равны</returns>
    public static bool operator != (Rational r1, Rational r2)
    {
        return Rational.Fraction(r1) != Rational.Fraction(r2);
    }



    /// <summary>
    /// Перегрузка оператора '<' для сравнение двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональные числа</param>
    /// <param name="r2">второй рациональные числа</param>
    /// <returns>возвращает true, если второй больше чем первый, false, если первый больше чем второй</returns>
    public static bool operator <(Rational r1, Rational r2)
    {
        return Rational.Fraction(r1) < Rational.Fraction(r2);
    }




    /// <summary>
    /// Перегрузка оператора '>' для сравнение двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональные числа</param>
    /// <param name="r2">второй рациональные числа</param>
    /// <returns>возвращает true, если первый больше чем второй, false, если первый меньше чем второй</returns>
    public static bool operator >(Rational r1, Rational r2)
    {
        return Rational.Fraction(r1) > Rational.Fraction(r2);
    }



    /// <summary>
    /// Перегрузка оператора '<=' для сравнение двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональные числа</param>
    /// <param name="r2">второй рациональные числа</param>
    /// <returns>возвращает true, если второй больше первого или равен, false, если первый больше чем второй</returns>
    public static bool operator <=(Rational r1, Rational r2)
    {
        return Rational.Fraction(r1) <= Rational.Fraction(r2);
    }



    /// <summary>
    /// Перегрузка оператора '>=' для сравнение двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональные числа</param>
    /// <param name="r2">второй рациональные числа</param>
    /// <returns>возвращает true, если первый больше второго или равен, false, если второй больше чем первый</returns>
    public static bool operator >=(Rational r1, Rational r2)
    {
        return Rational.Fraction(r1) >= Rational.Fraction(r2);
    }


    /// <summary>
    /// Метод, для определение обычные дроби в десятичные
    /// </summary>
    /// <param name="rational">Объект рационального числа</param>
    /// <returns>возвращает десятичный дробь</returns>
    public static double Fraction(Rational rational) => rational._numerator / rational._denominator;

    /// <summary>
    /// Метод, для нахождение обшего знаменателя
    /// </summary>
    /// <param name="r1">первый рациональные числа</param>
    /// <param name="r2">второй рациональные числа</param>
    /// <param name="R1">возвращает первый новый рациональные числа</param>
    /// <param name="R2">возвращает второй новый рациональные числа</param>
    public static void Denominator(Rational r1, Rational r2, out Rational R1, out Rational R2)
    {
        int count_r1=1, count_r2=1;
        double _denominator1 = r1._denominator;
        double _denominator2 = r2._denominator;
        while (r1._denominator != r2._denominator)
        {
            if(r1._denominator > r2._denominator)
            {
                r2._denominator+= _denominator2;
                count_r2++;
                if(r1._denominator == r2._denominator)
                {
                    break;
                }
                r1._numerator += _denominator1;
                count_r1++;
            }
            else if (r1._denominator < r2._denominator)
            {
                r1._denominator += _denominator1;
                count_r1++;
                if (r1._denominator == r2._denominator)
                {
                    break;
                }
                r2._denominator += _denominator2;
                count_r2++;
            }
        }
        r1._numerator*=count_r1;
        r2._numerator*=count_r2;
        R1 = r1;
        R2 = r2;
    }
}