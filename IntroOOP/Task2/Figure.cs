namespace IntroOOP.Task2;

public class Figure
{
    #region FIELDS
    protected string _color = ""; //цвет фигуры

    protected bool _state;        // состояние

    protected int _x;             //координата по оси х

    protected int _y;             //координата по оси уы
    #endregion

    /// <summary>
    /// Конструктор с четырьмя параметрами
    /// </summary>
    /// <param name="color">цвет фигуры</param>
    /// <param name="state">статус</param>
    /// <param name="x">координаты по оси х</param>
    /// <param name="y">координата по оси у</param>
    public Figure(string color, bool state, int x, int y)
    {
        _color = color;
        _state = state;
        _x = x;
        _y = y;
    }

    #region METHODS

    /// <summary>
    /// Виртуальный метод, для перемешение фигур по горизонтальный линии
    /// </summary>
    /// <param name="step">количество шагов</param>
    /// <param name="direction">направления</param>
    public virtual void MoveHorizontal(int step, Direction direction)
    {
        if (direction == Direction.RIGHT)
            _x += step;
        else if(direction == Direction.LEFT)
            _x -= step;
    }

    /// <summary>
    /// Виртуальный метод, для перемешение фигур по вертикальный линии
    /// </summary>
    /// <param name="step">количество шагов</param>
    /// <param name="direction">направления</param>
    public virtual void MoveVertical(int step, Direction direction)
    {
        if (direction == Direction.UP)
            _y += step;
        else if(direction==Direction.DOWN)
            _y -= step;
    }

    /// <summary>
    /// Виртуальный метод, для изменение цвета фигур
    /// </summary>
    /// <param name="color">цвет фигур</param>
    public virtual void ChangeColorFigure(string color) => this._color = color;

    /// <summary>
    /// Виртуальный метод, для изменение состояние фигур
    /// </summary>
    /// <param name="state">состояние фигур</param>
    public virtual void ChangeStateFigure(bool state) => this._state = state;

    /// <summary>
    /// Переопределенный метод ToString, для формата вывода строки
    /// </summary>
    /// <returns>формат строки</returns>
    public override string ToString() => $"Цвет:{_color}, состояние:{_state}," +
        $" координата по оси х:{_x}, координата по оси у:{_y}";

    #endregion
}