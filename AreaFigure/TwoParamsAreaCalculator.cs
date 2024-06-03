using static AreaFigure.NameConstants;

namespace AreaFigure;

internal sealed class TwoParamsAreaCalculator : BaseParamsAreaCalculator
{
    internal TwoParamsAreaCalculator(int param1, int param2) : base([param1, param2])
    {
        AddFunction(DiamondByHeight, _ => param1 * param2);
        AddFunction(TrapezoidByMidlineAndHeight, _ => param1 * param2);
        AddFunction(ParallelogramByHeight, _ => param1 * param2);
        AddFunction(Rectangle, _ => param1 * param2);

        AddFunction(TriangleByAltitudeAndIsosceles, _ => (param1 * param2) / 2m);
        AddFunction(Ellipse, _ => (decimal)(Math.PI * param1 * param2));
    }
}