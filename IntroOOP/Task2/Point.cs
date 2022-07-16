namespace IntroOOP.Task2;

public  class Point : Figure
{

    /// <summary>
    /// Конструктор с четырьмя параметрами
    /// </summary>
    /// <param name="color">цвет точки</param>
    /// <param name="state">статус</param>
    /// <param name="x">координата по оси х</param>
    /// <param name="y">координата по оси у</param>
    public Point(string color, bool state, int x, int y) : base(color, state, x, y)
    {
    }


    #region METHODS

    /// <summary>
    /// Виртуальный метод, для нахождение площадь фигур у наследника
    /// </summary>
    public virtual void Area() { }


    /// <summary>
    /// Виртуальный метод, для нахождение периметр фигур у наследника
    /// </summary>
    public virtual void Perimetr() { }


    /// <summary>
    /// Переопределенный метод ToString, для формат вывода строки
    /// </summary>
    /// <returns>возвращает формат строки</returns>
    public override string ToString() => $"Цвет фигуры:{_colorFigure}, статус:{_state}, координата по оси х:{_x}, координата по оси у:{_y}";
    #endregion
}