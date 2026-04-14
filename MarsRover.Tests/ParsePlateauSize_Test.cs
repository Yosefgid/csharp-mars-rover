using MarsRover.ConsoleApp;
using MarsRover.ConsoleApp.Parsers;

namespace MarsRover.Tests;

public class NUnitTestItem2
{
    [Test]
    public void ParsePlateauSize_ReturnsCorrectXandY_forValidInput()
    {
        //Arrange
        var parser = new InputParser();
        var input = "5 5";

        //Assert
        var result = parser.ParsePlateauSize(input);

        //Assert
        Assert.That(result, Is.EqualTo(new PlateauSize { Width = 5, Height = 5 }));

    }
}
