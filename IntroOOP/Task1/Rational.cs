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
    /// Перегрузка оператора +, для сложения двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональное число</param>
    /// <param name="r2">второй рациональное число</param>
    /// <returns>возвращает новый рациональное число</returns>
    public static Rational operator +(Rational r1, Rational r2)
    {
        Denominator(r1, r2, out Rational R1, out Rational R2);
        return new Rational(R1._numerator + R2._numerator, R1._denominator);
    }


    /// <summary>
    /// Перегрузка оператора +, для сложения рационального числа и переменный типа double
    /// </summary>
    /// <param name="r1">рациональное число</param>
    /// <param name="numerator">переменный типа double</param>
    /// <returns>возвращает новый рациональное число</returns>
    public static Rational operator +(Rational r1, double numerator)
    {
        Rational r2 = new(numerator, 1);
        Denominator(r1, r2, out Rational R1, out Rational R2);
        return new Rational(R1._numerator + R2._numerator, R1._denominator);
    }




    /// <summary>
    /// Перегрузка оператора +, для сложения переменный типа double и рационального числа 
    /// </summary>
    /// <param name="numerator">переменный типа double</param>
    /// <param name="r2">рациональное число</param>
    /// <returns>возвращает новый рациональное число</returns>
    public static Rational operator +(double numerator, Rational r2)
    {
        Rational r1 = new(numerator, 1);
        Denominator(r1, r2, out Rational R1, out Rational R2);
        return new Rational(R1._numerator + R2._numerator, R1._denominator);
    }






    /// <summary>
    /// Перегрузка оператора -, для вычитание двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональное число</param>
    /// <param name="r2">второй рациональное число</param>
    /// <returns>возвращает новый рациональное число</returns>
    public static Rational operator -(Rational r1, Rational r2)
    {
        Denominator(r1, r2, out Rational R1, out Rational R2);
        return new Rational(R1._numerator - R2._numerator, R1._denominator);
    }




    /// <summary>
    /// Перегрузка оператора -, для вычитание  рационального числа и переменный типа double
    /// </summary>
    /// <param name="r1">рациональное число</param>
    /// <param name="numerator">переменный типа double</param>
    /// <returns>возвращает новый рациональное число</returns>
    public static Rational operator -(Rational r1, double numerator)
    {
        Rational r2 = new(numerator, 1);
        Denominator(r1, r2, out Rational R1, out Rational R2);
        return new Rational(R1._numerator - R2._numerator, R1._denominator);
    }



    /// <summary>
    /// Перегрузка оператора -, для вычитание переменный типа double и рационального числа  
    /// </summary>
    /// <param name="numerator">переменный типа double</param>
    /// <param name="r2">рациональное число</param>
    /// <returns>возвращает новый рациональное число</returns>
    public static Rational operator -(double numerator, Rational r2)
    {
        Rational r1 = new(numerator, 1);
        Denominator(r1, r2, out Rational R1, out Rational R2);
        return new Rational(R1._numerator - R2._numerator, R1._denominator);
    }





    /// <summary>
    /// Перегрузка оператора *, для умножение двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональное число</param>
    /// <param name="r2">второй рациональное число</param>
    /// <returns>возвращает новый рациональное число</returns>

    public static Rational operator *(Rational r1, Rational r2)
    {
        return new Rational(r1._numerator * r2._numerator, r1._denominator * r2._denominator);
    }


    /// <summary>
    /// Перегрузка оператора *, для умножение рационального числа и переменный типо double
    /// </summary>
    /// <param name="r1">рациональное число</param>
    /// <param name="numerator">переменный типа double</param>
    /// <returns>возвращает новый рациональное число</returns>
    public static Rational operator *(Rational r1, double numerator)
    {
        return new Rational(r1._numerator * numerator, r1._denominator);
    }



    /// <summary>
    /// Перегрузка оператора *, для умножение переменный типо double и рационального числа 
    /// </summary>
    /// <param name="numerator">переменный типа double</param>
    /// <param name="r2">рациональное число</param>
    /// <returns>возвращает новый рациональное число</returns>

    public static Rational operator *(double numerator, Rational r2)
    {
        return new Rational(numerator * r2._numerator, r2._denominator);
    }


    /// <summary>
    /// Перегрузка оператора == для сравнение двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональное число</param>
    /// <param name="r2">второй рациональное число</param>
    /// <returns>возвращает true, если они равны, false, если не равны</returns>
    public static bool operator == (Rational r1, Rational r2)
    {
        return Rational.Fraction(r1)==Rational.Fraction(r2);
    }



    /// <summary>
    /// Перегрузка оператора != для сравнение двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональное число</param>
    /// <param name="r2">второй рациональное число</param>
    /// <returns>возвращает true, если они не равны, false, если равны</returns>
    public static bool operator != (Rational r1, Rational r2)
    {
        return Rational.Fraction(r1) != Rational.Fraction(r2);
    }



    /// <summary>
    /// Перегрузка оператора '<' для сравнение двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональное число</param>
    /// <param name="r2">второй рациональное число</param>
    /// <returns>возвращает true, если второй больше чем первый, false, если первый больше чем второй</returns>
    public static bool operator <(Rational r1, Rational r2)
    {
        return Rational.Fraction(r1) < Rational.Fraction(r2);
    }




    /// <summary>
    /// Перегрузка оператора '>' для сравнение двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональное число</param>
    /// <param name="r2">второй рациональное число</param>
    /// <returns>возвращает true, если первый больше чем второй, false, если первый меньше чем второй</returns>
    public static bool operator >(Rational r1, Rational r2)
    {
        return Rational.Fraction(r1) > Rational.Fraction(r2);
    }



    /// <summary>
    /// Перегрузка оператора '<=' для сравнение двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональное число</param>
    /// <param name="r2">второй рациональное число</param>
    /// <returns>возвращает true, если второй больше первого или равен, false, если первый больше чем второй</returns>
    public static bool operator <=(Rational r1, Rational r2)
    {
        return Rational.Fraction(r1) <= Rational.Fraction(r2);
    }



    /// <summary>
    /// Перегрузка оператора '>=' для сравнение двух рациональных чисел
    /// </summary>
    /// <param name="r1">первый рациональное число</param>
    /// <param name="r2">второй рациональное число</param>
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
    /// <param name="r1">первый рациональное число</param>
    /// <param name="r2">второй рациональное число</param>
    /// <param name="R1">возвращает первый новый рациональное число</param>
    /// <param name="R2">возвращает второй новый рациональное число</param>
    public static void Denominator(Rational r1, Rational r2, out Rational R1, out Rational R2)
    {
        double count_r1, count_r2;
        double _denominator1 = r1._denominator;
        double _denominator2 = r2._denominator;
        double nod, nok;
        while (_denominator1 !=0 && _denominator2!=0)
        {
            if(_denominator1>_denominator2)
            {
                _denominator1%=_denominator2;
            }
            else if(_denominator2>_denominator1)
            {
                _denominator2 %= _denominator1;
            }
        }
        nod = _denominator1 + _denominator2;
        nok = (r1._denominator * r2._denominator) / nod;
        count_r1 = nok / r1._denominator;
        count_r2 = nok / r2._denominator;
        r1._numerator *= count_r1;
        r2._numerator *= count_r2;
        R1 = r1;
        R2 = r2;
    }
}