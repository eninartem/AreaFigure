using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Xunit;
using static AreaFigure.NameConstants;

namespace AreaFigure.Tests;

[TestSubject(typeof(TwoParamsAreaCalculator))]
public class TwoParamsAreaCalculatorTest
{
    [Theory]
    [ClassData(typeof(TwoParamsAreaSuccessTestData))]
    public void CalculateArea_Success_Test(int param1, int param2, IReadOnlyCollection<ReceivedArea> assertAreas)
    {
        // Arrange
        var calc = new TwoParamsAreaCalculator(param1, param2);

        // Act
        var result = calc.CalculateAreas();

        var diamondByHeightArea = result.First(r => r.RecognizedFigure == DiamondByHeight).Area;
        
        var trapezoidByMidlineAndHeightArea = 
            result.First(r => r.RecognizedFigure == TrapezoidByMidlineAndHeight).Area;
        
        var parallelogramByHeightArea = result.First(r => r.RecognizedFigure == ParallelogramByHeight).Area;
        
        var rectangleArea = result.First(r => r.RecognizedFigure == Rectangle).Area;
        
        var triangleByAltitudeAndIsoscelesArea = 
            result.First(r => r.RecognizedFigure == TriangleByAltitudeAndIsosceles).Area;
        
        var ellipseArea = result.First(r => r.RecognizedFigure == Ellipse).Area;

        // Assert
        Assert.Equal(diamondByHeightArea, assertAreas.First(r => r.RecognizedFigure == DiamondByHeight).Area);
       
        Assert.Equal(trapezoidByMidlineAndHeightArea, 
            assertAreas.First(r => r.RecognizedFigure == TrapezoidByMidlineAndHeight).Area);
        
        Assert.Equal(parallelogramByHeightArea, 
            assertAreas.First(r => r.RecognizedFigure == ParallelogramByHeight).Area);
        
        Assert.Equal(rectangleArea, assertAreas.First(r => r.RecognizedFigure == Rectangle).Area);
       
        Assert.Equal(triangleByAltitudeAndIsoscelesArea, 
            assertAreas.First(r => r.RecognizedFigure == TriangleByAltitudeAndIsosceles).Area);
       
        Assert.Equal(ellipseArea, assertAreas.First(r => r.RecognizedFigure == Ellipse).Area);
    }
}