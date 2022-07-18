namespace IntroOOP.Task2;

public class Square : Point
{
    private int _a;  // сторона квадрата

    /// <summary>
    /// Конструктор с шестью параметрами
    /// </summary>
    /// <param name="color">цвет</param>
    /// <param name="state">состояние</param>
    /// <param name="x">координата по оси х</param>
    /// <param name="y">координата по оси у</param>
    /// <param name="name">название</param>
    /// <param name="a">сторона</param>
    public Square(string color,
                  bool state,
                  int x,
                  int y,
                  string name,
                  int a)
                  : base(color, state, x, y, name)
    {
        _a = a;
    }

    #region METHODS

    /// <summary>
    /// Переопределенный метод GetArea, для нахождение площадь квадрата
    /// </summary>
    /// <returns>возвращает площадь квадрата</returns>
    public override double GetArea() => _a * _a;

    /// <summary>
    /// Переопределенный метод GetPerimetr, для нахождение периметр квадрата
    /// </summary>
    /// <returns>возвращает периметр квадрата</returns>
    public override double GetPerimetr() => 4 * _a;

    /// <summary>
    /// Переопределенный метод ToString, для формата вывода строки
    /// </summary>
    /// <returns>формат строки</returns>
    public override string ToString() => $"Цвет:{_color}, состояние:{_state}," +
        $" координата по оси х:{_x}, координата по оси у:{_y}, название фигур:{Name}," +
        $"сторона:{_a}, Площадь:{GetArea()}, Периметр:{GetPerimetr()}";
    #endregion
}