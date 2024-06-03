using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Xunit;
using static AreaFigure.NameConstants;

namespace AreaFigure.Tests;

[TestSubject(typeof(OneParamsAreaCalculator))]
public class OneParamsAreaCalculatorTest
{
    [Theory]
    [ClassData(typeof(OneParamsAreaSuccessTestData))]
    public void CalculateArea_Success_Test(int param, IReadOnlyCollection<ReceivedArea> assertAreas)
    {
        // Arrange
        var calc = new OneParamsAreaCalculator(param);

        // Act
        var result = calc.CalculateAreas();

        var triangleArea = result.First(r => r.RecognizedFigure == EquilateralTriangle).Area;
        var circleArea = result.First(r => r.RecognizedFigure == Circle).Area;
        var squareArea = result.First(r => r.RecognizedFigure == Square).Area;

        // Assert
        Assert.Equal(triangleArea, assertAreas.First(r => r.RecognizedFigure == EquilateralTriangle).Area);
        Assert.Equal(circleArea, assertAreas.First(r => r.RecognizedFigure == Circle).Area);
        Assert.Equal(squareArea, assertAreas.First(r => r.RecognizedFigure == Square).Area);
    }
}