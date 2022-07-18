namespace IntroOOP.Task2;

public class Circle : Point
{
    private int _radius; // радиус

    /// <summary>
    /// Конструктор с шестью параметрами
    /// </summary>
    /// <param name="color">цвет</param>
    /// <param name="state">состояние</param>
    /// <param name="x">координата по оси х</param>
    /// <param name="y">координата по оси у</param>
    /// <param name="name">название фигур</param>
    /// <param name="radius">радиус</param>
    public Circle(string color,
                  bool state,
                  int x,
                  int y,
                  string name,
                  int radius)
                  : base(color, state, x, y, name)
    {
        _radius = radius;
    }

    #region METHODS
    /// <summary>
    /// Переопределенный метод GetArea, для нахождение площадь окружности
    /// </summary>
    /// <returns>возвращает площадь окружности</returns>
    public override double GetArea() => Math.PI * _radius * _radius;

    /// <summary>
    /// Переопределенный метод GetPerimetr, для нахождение периметр окружности
    /// </summary>
    /// <returns>возвращает периметр окружности</returns>
    public override double GetPerimetr() => 2 * Math.PI * _radius;

    /// <summary>
    /// Переопределенный метод ToString, для формата вывода строки
    /// </summary>
    /// <returns>формат строки</returns>
    public override string ToString() => $"Цвет:{_color}, состояние:{_state}," +
        $" координата по оси х:{_x}, координата по оси у:{_y}, название фигур:{Name}," +
        $"Радиус:{_radius}, Площадь:{GetArea()}, Периметр:{GetPerimetr()}";
    #endregion
}