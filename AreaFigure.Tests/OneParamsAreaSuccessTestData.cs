using System.Collections;
using System.Collections.Generic;

using static AreaFigure.NameConstants;
using static AreaFigure.MathConstants;

namespace AreaFigure.Tests;

internal class OneParamsAreaSuccessTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return
        [
            5,
            new List<ReceivedArea>
            {
                new(EquilateralTriangle, 10.825m),
                new(Circle, 78.55m),
                new(Square, 25)
            }
        ];
        yield return
        [
            4,
            new List<ReceivedArea>
            {
                new(EquilateralTriangle, 6.928m),
                new(Circle, 50.272m),
                new(Square, 16)
            }
        ];
        yield return
        [
            3,
            new List<ReceivedArea>
            {
                new(EquilateralTriangle, 3.897m),
                new(Circle, 28.278m),
                new(Square, 9)
            }
        ];
        yield return
        [
            2,
            new List<ReceivedArea>
            {
                new(EquilateralTriangle, 1.732m),
                new(Circle, 12.568m),
                new(Square, 4)
            }
        ];
        yield return
        [
            1,
            new List<ReceivedArea>
            {
                new(EquilateralTriangle, 0.433m),
                new(Circle, (decimal)PiNumber),
                new(Square, 1)
            }
        ];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}