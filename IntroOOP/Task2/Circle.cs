namespace IntroOOP.Task2;

public class Circle : Point
{
    #region FIELDS
    int radius;

    double area, perimetr;
    #endregion
    public Circle(string color, bool state, int x, int y, int radius) : base(color, state, x, y)
    {
        this.radius = radius;
    }

    #region METHODS

    /// <summary>
    /// Переопределенный метод Perimetr, для нахождение периметр для окружности
    /// </summary>
    public override void Perimetr() => perimetr = 2*Math.PI*radius;



    /// <summary>
    /// Переопределенный метод Area, для нахождение площадь для окружности
    /// </summary>
    public override void Area() => area = Math.PI * radius * radius;



    /// <summary>
    /// Переопределенный метод ToString, для формат вывода строки
    /// </summary>
    /// <returns>возвращает формат строки</returns>
    public override string ToString() => $"Цвет фигуры:{_colorFigure}, статус:{_state}, координата по оси х:{_x}, координата по оси у:{_y}\nРадиус:{radius}, периметр:{perimetr}, площадь:{area}";

    #endregion
}