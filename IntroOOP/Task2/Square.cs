namespace IntroOOP.Task2;

public class Square : Point
{
    #region FIELDS
    private int _a;

    private double _area, _perimetr;
    #endregion

    public Square(string color, bool state, int x, int y, int a) : base(color, state, x, y)
    {
        _a = a;
    }

    #region METHODS

    /// <summary>
    /// Переопределенный метод Area, для нахождение площадь квадрата
    /// </summary>
    public override void Area() => _area = _a * _a;


    /// <summary>
    /// Переопределенный метод Perimetr, для нахождение периметр квадрата
    /// </summary>
    public override void Perimetr() => _perimetr = 4 * _a;


    /// <summary>
    /// Переопределенный метод ToString, для формата вывода строки
    /// </summary>
    /// <returns>возвращает формат строки</returns>
    public override string ToString() => $"Цвет фигуры:{_colorFigure}, статус:{_state}, координата по оси х:{_x}, координата по оси у:{_y}\nсторона а:{_a}, периметр:{_perimetr}, площадь:{_area}";

    #endregion
}