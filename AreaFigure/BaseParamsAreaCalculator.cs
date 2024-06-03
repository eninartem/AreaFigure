using System.Collections.Immutable;

namespace AreaFigure;

internal abstract class BaseParamsAreaCalculator(double[] data)
{
    private readonly Dictionary<string, Func<double[], decimal>> _calcFunctions = new ();

    internal void AddFunction(string figureName, Func<double[], decimal> func) => _calcFunctions.TryAdd(figureName, func);

    internal IReadOnlyCollection<ReceivedArea> CalculateAreas() =>
        _calcFunctions.Select(f => new ReceivedArea(f.Key, Math.Round(f.Value.Invoke(data), 3))).ToImmutableArray();
}