using Xunit;
using Xunit.Abstractions;

namespace AoC2021Day10;

public class Part1ProcessorTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Part1ProcessorTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void GivenTestInputData_ResultShouldBeCorrect()
    {
        // Arrange
        var testInputData = System.IO.File.ReadAllLines("InputData/TestInput.txt");
        
        // Act
        var result = Part1Processor.Execute(testInputData);

        // Assert
        Assert.Equal(26397, result);
    }
    
    [Fact]
    public void GivenPuzzleInputData_ResultShouldBeCorrect()
    {
        // Arrange
        var testInputData = System.IO.File.ReadAllLines("InputData/MyPuzzleInput.txt");
        
        // Act
        var result = Part1Processor.Execute(testInputData);

        // Assert
        _testOutputHelper.WriteLine(result.ToString());
    }

    [Fact]
    public void GivenChunkStartsWithClosingBracket_ShouldReturnCorrectScore()
    {
        // Arrange
        var testInputDataString = new [] {"}"};
        
        // Act
        var result = Part1Processor.Execute(testInputDataString);
        
        // Assert
        Assert.Equal(1197, result);
    }
}