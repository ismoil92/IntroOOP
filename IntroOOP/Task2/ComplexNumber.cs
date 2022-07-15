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
    /// Переопределение метода ToString, для изменение формати строки
    /// </summary>
    /// <returns>возвращает новый формат строки</returns>
    public override string ToString() => $"Действительное число:{a}, мнимая часть:{b}, мнимая единица:{i}, Комлексные числа:{a}+{b}{i}";
}