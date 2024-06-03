using System.Collections;
using System.Collections.Generic;
using static AreaFigure.Constants.NameConstants;

namespace AreaFigure.Tests.TwoParamTests;

internal class TwoParamsAreaSuccessTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return
        [
            5, 6,
            new List<ReceivedArea>
            {
                new(DiamondByHeight, 30m),
                new(TrapezoidByMidlineAndHeight, 30m),
                new(ParallelogramByHeight, 30m),
                new(Rectangle, 30m),
                new(TriangleByAltitudeAndIsosceles, 15m),
                new(Ellipse, 94.248m)
            }
        ];
        yield return
        [
            3, 4,
            new List<ReceivedArea>
            {
                new(DiamondByHeight, 12m),
                new(TrapezoidByMidlineAndHeight, 12m),
                new(ParallelogramByHeight, 12m),
                new(Rectangle, 12m),
                new(TriangleByAltitudeAndIsosceles, 6m),
                new(Ellipse, 37.699m)
            }
        ];
        yield return
        [
            3, 3,
            new List<ReceivedArea>
            {
                new(DiamondByHeight, 9m),
                new(TrapezoidByMidlineAndHeight, 9m),
                new(ParallelogramByHeight, 9m),
                new(Rectangle, 9m),
                new(TriangleByAltitudeAndIsosceles, 4.5m),
                new(Ellipse, 28.274m)
            }
        ];
        yield return
        [
            2, 2,
            new List<ReceivedArea>
            {
                new(DiamondByHeight, 4m),
                new(TrapezoidByMidlineAndHeight, 4m),
                new(ParallelogramByHeight, 4m),
                new(Rectangle, 4m),
                new(TriangleByAltitudeAndIsosceles, 2m),
                new(Ellipse, 12.566m)
            }
        ];
        yield return
        [
            1, 1,
            new List<ReceivedArea>
            {
                new(DiamondByHeight, 1m),
                new(TrapezoidByMidlineAndHeight, 1m),
                new(ParallelogramByHeight, 1m),
                new(Rectangle, 1m),
                new(TriangleByAltitudeAndIsosceles, 0.5m),
                new(Ellipse, 3.142m)
            }
        ];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}