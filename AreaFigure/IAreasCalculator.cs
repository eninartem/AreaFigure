namespace AreaFigure;

/// <summary>
/// Фабрика возвращает калькуляторы
/// </summary>
public interface IAreasCalculator
{
    /// <summary>
    /// Для подсчета площадей двумерных фигур достаточно иметь 1-3 значения. 
    /// </summary>
    /// <param name="param1">Первоя сторона (или радиус, полуось в случае эллипса). Обязательна.</param>
    /// <param name="param2">Вторая сторона (или высота).</param>
    /// <param name="param3">Угол в случае треугольника.</param>
    /// <returns></returns>
    public IReadOnlyCollection<ReceivedArea> GetAreas(int param1, int? param2 = null, int? param3 = null);
}