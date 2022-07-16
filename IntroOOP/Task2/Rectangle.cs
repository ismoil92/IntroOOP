namespace IntroOOP.Task2;

public class Rectangle : Point
{
    #region FIELDS
    private int _a, _b;

    private double _area, _perimetr;

    #endregion

    public Rectangle(string color, bool state, int x, int y, int a, int b) : base(color, state, x, y)
    {
        _a= a;
        _b= b;
    }


    #region METHODS

    /// <summary>
    /// Переопределенный метод Area, для нахождение площадь прямоугольника
    /// </summary>
    public override void Area() => _area = _a * _b;


    /// <summary>
    /// Переопределенный метод Perimetr, для нахождение периметр прямоугольника
    /// </summary>
    public override void Perimetr() => _perimetr = 2 * (_a + _b);

    /// <summary>
    /// Переопределенный метод ToString, для формата вывода строки
    /// </summary>
    /// <returns>возвращает формат строки</returns>
    public override string ToString() => $"Цвет фигуры:{_colorFigure}, статус:{_state}, координата по оси х:{_x}, координата по оси у:{_y}\nсторона а:{_a}, сторона b:{_b}, периметр:{_perimetr}, площадь:{_area}";
    #endregion
}