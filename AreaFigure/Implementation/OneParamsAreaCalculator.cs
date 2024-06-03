using AreaFigure.Contracts;
using static AreaFigure.Constants.NameConstants;
using static AreaFigure.Constants.MathConstants;

namespace AreaFigure.Implementation;

/// <summary>
/// Возвращает функции, которые могут считать площади фигур по 1 параметру
/// </summary>
internal sealed class OneParamsAreaCalculator : BaseParamsAreaCalculator
{
    internal OneParamsAreaCalculator(int param) : base([param])
    {
        AddFunction(EquilateralTriangle, _ => (decimal)((Math.Pow(param, 2) * SquareFromThree) / 4));
        AddFunction(Circle, _ => (decimal)(PiNumber * Math.Pow(param, 2)));
        AddFunction(Square, _ => (decimal)Math.Pow(param, 2));
    }
}