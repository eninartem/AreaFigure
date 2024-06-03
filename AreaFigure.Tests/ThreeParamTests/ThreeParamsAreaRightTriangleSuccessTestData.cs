using System.Collections;
using System.Collections.Generic;
using static AreaFigure.Constants.NameConstants;

namespace AreaFigure.Tests.ThreeParamTests;

internal class ThreeParamsAreaRightTriangleSuccessTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return
        [
            8, 10, 36.870,
            new List<ReceivedArea>
            {
                new(RightTriangle, 24.0m)
            }
        ];
        yield return
        [
            12, 13, 22.62,
            new List<ReceivedArea>
            {
                new(RightTriangle, 30.0m)
            }
        ];
        yield return
        [
            3, 4, 90,
            new List<ReceivedArea>
            {
                new(RightTriangle, 6m)
            }
        ];
    }
    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}