namespace IntroOOP.Task2;

public abstract class Point : Figure, IFigure
{
    protected string _name; // название фигуры

    /// <summary>
    /// Конструктор с пятью параметрами
    /// </summary>
    /// <param name="color">цвет</param>
    /// <param name="state">состояние</param>
    /// <param name="x">координата по оси х</param>
    /// <param name="y">координата по оси у</param>
    /// <param name="name">название фигуры</param>
    public Point(string color,
                 bool state,
                 int x,
                 int y,
                 string name)
                 : base(color, state, x, y)
    {
        _name = name;
    }

    public string Name { get => _name; } // Свойство, Название фигуры


    #region METHODS

    /// <summary>
    /// Абстрактный метод, для нахождение площадь фигур
    /// </summary>
    /// <returns>возвращает площадь фигур</returns>
    public abstract double GetArea();

    /// <summary>
    /// Абстрактный метод, для нахождение периметр фигур
    /// </summary>
    /// <returns>возвращает периметр фигур</returns>
    public abstract double GetPerimetr();

    /// <summary>
    /// Переопределенный метод ToString, для формата вывода строки
    /// </summary>
    /// <returns>формат строки</returns>
    public override string ToString() => $"Цвет:{_color}, состояние:{_state}," +
        $" координата по оси х:{_x}, координата по оси у:{_y}, название фигур:{Name}";
    #endregion
}