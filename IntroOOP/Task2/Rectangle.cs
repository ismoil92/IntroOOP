namespace IntroOOP.Task2;

public class Rectangle:Point
{
    #region FIELDS
    private int _a;  // одна сторона прямоугольника

    private int _b; // вторая сторона прямоугольника
    #endregion

    /// <summary>
    /// Контруктор с семью параметрами
    /// </summary>
    /// <param name="color">цвет</param>
    /// <param name="state">состояние</param>
    /// <param name="x">координата по оси х</param>
    /// <param name="y">координата по оси у</param>
    /// <param name="name">название фигур</param>
    /// <param name="a">одна сторона</param>
    /// <param name="b">вторая сторона</param>
    public Rectangle(string color,
                     bool state,
                     int x,
                     int y,
                     string name,
                     int a,
                     int b)
                     : base(color, state, x, y, name)
    {
        _a = a;
        _b = b;
    }

    #region METHODS

    /// <summary>
    /// Переопределенный метод GetArea, для нахождение площадь прямоугольника
    /// </summary>
    /// <returns>возвращает площадь прямоугольника</returns>
    public override double GetArea() => _a * _b;

    /// <summary>
    /// Переопределенный метод GetPerimetr, для нахождение периметр прямоугольника
    /// </summary>
    /// <returns>возвращает периметр прямоугольника</returns>
    public override double GetPerimetr() => 2 * (_a + _b);

    /// <summary>
    /// Переопределенный метод ToString, для формата вывода строки
    /// </summary>
    /// <returns>формат строки</returns>
    public override string ToString() => $"Цвет:{_color}, состояние:{_state}," +
        $" координата по оси х:{_x}, координата по оси у:{_y}, название фигур:{Name}," +
        $" сторона а:{_a}, сторона b:{_b}, Площадь:{GetArea()}, Периметр:{GetPerimetr()}";

    #endregion

}