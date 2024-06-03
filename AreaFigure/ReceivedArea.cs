namespace AreaFigure;

//Ввел данный клас из-за требования расчета площади без знания типа фигуры.
//Получая на входе, допустим только 1 значение, мы можем предполгать, что это
//квадрат, круг или равносторонний треугольник. Поэтому возвращаем несколько расчитаных площадей.

//Не нашел смысла создавать дженерик для фигур т.к. есть переплетения по кол-ву параметров для подсчета площади
//и особой пользы от обобщения не будет.

/// <summary>
/// Результат расчитанной площади с наименованием типа фигуры.
/// </summary>
/// <param name="recognizedFigure"></param>
/// <param name="area"></param>
public class ReceivedArea(string recognizedFigure, decimal area)
{
    /// <summary>
    /// Наименование фигуры.
    /// </summary>
    public string RecognizedFigure { get; } = recognizedFigure;
    
    /// <summary>
    /// Площадь.
    /// </summary>
    public decimal Area { get; } = area;
}