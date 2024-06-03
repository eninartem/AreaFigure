using AreaFigure.Contracts;
using static AreaFigure.Constants.NameConstants;

namespace AreaFigure.Implementation;

/// <summary>
/// Возвращает функции, которые могут считать площади фигур по 3 параметрам (в данном случае это только треугольники)
/// </summary>
internal sealed class ThreeParamsAreaCalculator : BaseParamsAreaCalculator
{
    internal ThreeParamsAreaCalculator(int param1, int param2, double param3) : base([param1, param2, param3])
    {
        if (param3 == 90)
        {
            AddFunction(RightTriangle, _ => (param1 * param2) / 2m);
            return;
        }
        
        var cos = Math.Cos(param3 * (Math.PI / 180.0));

        var thirdSide = Math.Sqrt(
            Math.Pow(param1, 2) + Math.Pow(param2, 2)
            - 2 * param1 * param2 * cos);
        
        //Сортирую стороны по убыванию так, что первая будет гипотенузой, остальные - катеты.
        var sides = new[] { param1, param2, thirdSide }.Order().ToList();
        
        //теорема Пифагора
        var isRectangular =
            Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 0.1;

        if (isRectangular)
        {
            AddFunction(RightTriangle, _ => (decimal)((sides[0] * sides[1]) / 2));
            return;
        }
        
        double angle = Math.PI * param3 / 180.0;
        AddFunction(Triangle, _ => (decimal)((param1 * param2 * Math.Sin(angle)) / 2));
    }
}