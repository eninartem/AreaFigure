using System.Collections.Generic;
using System.Linq;
using AreaFigure.Implementation;
using JetBrains.Annotations;
using Xunit;
using static AreaFigure.Constants.NameConstants;

namespace AreaFigure.Tests.ThreeParamTests;

[TestSubject(typeof(ThreeParamsAreaCalculator))]
public class ThreeParamsAreaCalculatorTest
{
    [Theory]
    [ClassData(typeof(ThreeParamsAreaTriangleSuccessTestData))]
    public void CalculateArea_Triangle_Success_Test(int param1, int param2, double param3, IReadOnlyCollection<ReceivedArea> assertAreas)
    {
        // Arrange
        var calc = new ThreeParamsAreaCalculator(param1, param2, param3);

        // Act
        var result = calc.CalculateAreas();

        var triangleArea = result.First(r => r.RecognizedFigure == Triangle).Area;

        // Assert
        Assert.Equal(triangleArea, assertAreas.First(r =>  r.RecognizedFigure == Triangle).Area);
    }
    
    [Theory]
    [ClassData(typeof(ThreeParamsAreaRightTriangleSuccessTestData))]
    public void CalculateArea_RightTriangle_Success_Test(int param1, int param2, double param3, IReadOnlyCollection<ReceivedArea> assertAreas)
    {
        // Arrange
        var calc = new ThreeParamsAreaCalculator(param1, param2, param3);

        // Act
        var result = calc.CalculateAreas();

        var triangleArea = result.First(r => r.RecognizedFigure == RightTriangle).Area;

        // Assert
        Assert.Equal(triangleArea, assertAreas.First(r => r.RecognizedFigure == RightTriangle).Area);
    }
}