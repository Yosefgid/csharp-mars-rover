using MarsRover.ConsoleApp;

namespace MarsRover.Tests
{
    public class Tests
    {
        [Test]
        public void ParseInstruction_ReturnsCorrectInstruction_ForTheRightInput()
        {
            //Arrange
            var parser = new InputParser();
            var input = "LRM";

            //Act
            var result = parser.ParseInstructions(input);

            //Assert
            Assert.That(result, Is.EqualTo(new List<Instruction>
            {
                Instruction.L,
                Instruction.R,
                Instruction.M
            }));
        }
    }
}