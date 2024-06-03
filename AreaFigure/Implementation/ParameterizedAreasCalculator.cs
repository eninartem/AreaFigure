using AreaFigure.Contracts;

namespace AreaFigure.Implementation;

/// <summary>
/// Параметризированный калькулятор.  
/// </summary>
public class ParameterizedAreasCalculator : IAreasCalculator
{
    /// <summary>
    /// Т.к. одним из требований было вычисление площади фигуры
    /// без знания типа фигуры в compile-time, было рпинято решение сделать метод который принимает
    /// только параметры (в данном случае 3 штуки т.к. для большинства формул требуется максимум 3)
    /// И не зная типа, можно расчитать площади для разных фигур с разным количеством параметров.
    /// Исходя из этого, было решено реализовать калькуляторы, что расчитывают все возможные фигуры
    /// исходя из требуемого кол-ва параметров.
    /// </summary>
    /// <param name="param1"></param>
    /// <param name="param2"></param>
    /// <param name="param3"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public IReadOnlyCollection<ReceivedArea> GetAreas(int param1, int? param2 = null, int? param3 = null)
    {
        if (param2 is null && param3 is null)
            return new OneParamsAreaCalculator(param1).CalculateAreas();

        if (param2 is not null && param3 is null)
            return new TwoParamsAreaCalculator(param1, param2.Value).CalculateAreas();

        if (param2 is not null && param3 is not null)
            return new ThreeParamsAreaCalculator(param1, param2.Value, param3.Value).CalculateAreas();

        throw new ArgumentException("Не правильно указаны параметры!");
    }
}