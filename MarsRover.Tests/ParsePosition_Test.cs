using MarsRover.ConsoleApp;
using MarsRover.ConsoleApp.Parsers;

namespace MarsRover.Tests;

public class ParsePosition_Test
{

    [Test]
    public void ParsePositions_ReturnsCorrectPositions_ForValidInputs()
    {
        //Arrange
        var parser = new InputParser();
        var input = "1 2 N";

        //Act
        var result = parser.ParsePositions(input);

        //Assert
        Assert.That(result, Is.EqualTo(new Position(1, 2, CompassDirection.N)));
    }
}
