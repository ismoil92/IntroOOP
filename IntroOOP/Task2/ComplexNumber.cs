namespace IntroOOP.Task2;

public class ComplexNumber
{ 
    private int a; // Действительный часть комплексного числа
    private int b; // мнимая часть комплексного числа
    private const char i = 'i'; // мнимая единица комплексного числа, i*i=-1

    public ComplexNumber(int a, int b)
    {
        this.a = a;
        this.b = b;
    }


    /// <summary>
    /// Перегрузка оператора + для комплексных чисел
    /// </summary>
    /// <param name="c1">первый комплексный число</param>
    /// <param name="c2">второй комплексный число</param>
    /// <returns>возвращает новый комплексный число</returns>
    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2) => new ComplexNumber(c1.a + c2.a, c1.b + c2.b);


    /// <summary>
    /// Перегрузка оператора - для комплексных чисел
    /// </summary>
    /// <param name="c1">первый комплексный число</param>
    /// <param name="c2">второй комплексный число</param>
    /// <returns>возвращает новый комплексный число</returns>

    public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2) => new ComplexNumber(c1.a - c2.a, c1.b - c2.b);



    /// <summary>
    /// Перегрузка оператора * для комплексных чисел
    /// </summary>
    /// <param name="c1">первый комплексный число</param>
    /// <param name="c2">второй комплексный число</param>
    /// <returns>возвращает новый комплексный число</returns>
    public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2) => new ComplexNumber((c1.a * c2.a - c1.b * c2.b), (c1.a * c2.b + c2.a * c1.b));




    /// <summary>
    /// Перегрузка оператора == для комплексных чисел
    /// </summary>
    /// <param name="c1">первый комплексный число</param>
    /// <param name="c2">второй комплексный число</param>
    /// <returns>возвращает true если комплексные числа равны, false если комплексные числа не равны</returns>
    public static bool operator ==(ComplexNumber c1, ComplexNumber c2) => Equals(c1, c2);




    /// <summary>
    /// Перегрузка оператора == для комплексных чисел
    /// </summary>
    /// <param name="c1">первый комплексный число</param>
    /// <param name="c2">второй комплексный число</param>
    /// <returns>возвращает true если комплексные числа не равны, false если комплексные числа равны</returns>
    public static bool operator !=(ComplexNumber c1, ComplexNumber c2) => !(c1==c2);




    /// <summary>
    /// Переопределение метода Equals для эквивалентности комплексных чисел
    /// </summary>
    /// <param name="obj">объект с которым будут сравнить</param>
    /// <returns>возвращает true если они эквивалентные, false если они не эквивалентные</returns>
    public override bool Equals(object? obj)
    {
        if(obj == null) return false;
        if(obj.GetType() != typeof(ComplexNumber)) return false;
        ComplexNumber comp = (ComplexNumber)obj;
        return this.a == comp.a && this.b == comp.b;
    }


    /// <summary>
    /// Переопределение метода GetHashCode, для получение хеш-кода
    /// </summary>
    /// <returns>возвращает хеш-код</returns>
    public override int GetHashCode()
    {
        int hash = 357;
        unchecked
        {
            hash = (hash * 0x18d) ^ a.GetHashCode();
            hash = (hash * 0x18d) * b.GetHashCode();
        }
        return hash;
    }


    /// <summary>
    /// Переопределение метода ToString, для изменение формати строки
    /// </summary>
    /// <returns>возвращает новый формат строки</returns>
    public override string ToString() => $"Действительное число:{a}, мнимая часть:{b}, мнимая единица:{i}, Комлексные числа:{a}+{b}{i}";
}