namespace AreaFigure;

public class ParameterizedAreasCalculator : IAreasCalculator
{
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