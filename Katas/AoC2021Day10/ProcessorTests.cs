using Xunit;

namespace AoC2021Day10;

public class ProcessorTests
{
    [Fact]
    public void GivenTestInputData_ResultShouldBeCorrect()
    {
        // Arrange
        var testInputData = System.IO.File.ReadAllLines("InputData/TestInput.txt");
        
        // Act
        var result = Processor.Execute(testInputData);

        // Assert
        Assert.Equal(26397, result);
    }
}