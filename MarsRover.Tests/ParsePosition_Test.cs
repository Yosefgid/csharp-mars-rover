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
    [Test] 
    public void ParsePosition_ReturnsCorrectPosition_ForDifferntValidInputs()
    {
        //Arrange
        var parser = new InputParser();
        var input = "3 3 E";

        //Act
        var result = parser.ParsePositions(input);

        //Assert
        Assert.That(result, Is.EqualTo(new Position(3, 3, CompassDirection.E)));
    }
    [Test]
    public void ParsePosition_ThrowsException_ForInvalidDirection()
    {
        var parser = new InputParser();
        var input = "3 3 Y";
        Assert.Throws<ArgumentException>(() => parser.ParsePositions(input));

    }
    [Test]
    public void ParsePosition_ThrowsException_ForEmptyString()
    {
        var parser = new InputParser();
        var input = "";
        Assert.Throws<ArgumentException>(() => parser.ParsePositions(input));

    }

}
