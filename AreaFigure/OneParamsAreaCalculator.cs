using static AreaFigure.NameConstants;
using static AreaFigure.MathConstants;

namespace AreaFigure;

internal sealed class OneParamsAreaCalculator : BaseParamsAreaCalculator
{
    internal OneParamsAreaCalculator(int param) : base([param])
    {
        AddFunction(EquilateralTriangle, _ => (decimal)((Math.Pow(param, 2) * SquareFromThree) / 4));
        AddFunction(Circle, _ => (decimal)(PiNumber * Math.Pow(param, 2)));
        AddFunction(Square, _ => (decimal)Math.Pow(param, 2));
    }
}