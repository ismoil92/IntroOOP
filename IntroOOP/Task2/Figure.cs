namespace IntroOOP.Task2;

public class Figure
{

    #region FIELDS
    protected string _colorFigure = "";


    protected bool _state;


    protected int _x, _y;
    #endregion

    /// <summary>
    /// Конструктор с четырьмя параметрами
    /// </summary>
    /// <param name="color">цвет фигуры</param>
    /// <param name="state">состояние видымости/невидымости </param>
    /// <param name="x">координата по оси х</param>
    /// <param name="y">координата по оси у</param>
    public Figure(string color, bool state, int x, int y)
    {
        _colorFigure = color;
        _state = state;
        _x = x;
        _y = y;
    }


    #region METHODS

    /// <summary>
    /// Метод, для передвижение по горизонтальный плоскости
    /// </summary>
    /// <param name="step">шаг передвижение</param>
    /// <param name="direction">направление</param>
    public void MoveHorizontal(int step, Direction direction)
    {
        if(direction == Direction.RIGHT)
            _x += step;
       else if(direction == Direction.LEFT)
            _x -= step;
    }



    /// <summary>
    /// Метод, для передвижение по горизонтальный плоскости
    /// </summary>
    /// <param name="step">шаг передвижение</param>
    /// <param name="direction">направление</param>
    public void MoveVertical(int step, Direction direction)
    {
        if (direction == Direction.UP)
            _y += step;
       else if(direction == Direction.DOWN)
        {
            _y -= step;
        }
    }

    /// <summary>
    /// Метод, для изменение цвета фигур
    /// </summary>
    /// <param name="color">изменяемы цвет фигуры</param>
    public void ChangeColorFigure(string color) => this._colorFigure = color;


    /// <summary>
    /// Метод, для изменение статуса. виден или не виден
    /// </summary>
    /// <param name="state">статус</param>
    public void ChangeState(bool state) => this._state = state;


    /// <summary>
    /// Переопределение метода ToString, для формата вывода строки
    /// </summary>
    /// <returns>возвращает формат строки</returns>
    public override string ToString() => $"Цвет фигуры:{_colorFigure}, статус:{_state}, координата по оси х:{_x}, координата по оси у:{_y}";
    #endregion

}