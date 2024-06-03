using System.Collections;
using System.Collections.Generic;
using static AreaFigure.Constants.NameConstants;

namespace AreaFigure.Tests.ThreeParamTests;

internal class ThreeParamsAreaTriangleSuccessTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return
        [
            7, 43, 28.74,
            new List<ReceivedArea>
            {
                new(Triangle, 72.366m)
            }
        ];
        yield return
        [
            4, 4, 60,
            new List<ReceivedArea>
            {
                new(Triangle, 6.928m)
            }
        ];
        yield return
        [
            1, 1, 25,
            new List<ReceivedArea>
            {
                new(Triangle, 0.211m)
            }
        ];
    }
    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}