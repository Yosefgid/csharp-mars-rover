using MarsRover.ConsoleApp;
using MarsRover.ConsoleApp.Parsers;

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

        [Test]
        public void ParseInstruction_ThrowsException_ForInvalidInput()
        {  
            //Arrange
            var parser = new InputParser();
            var input = "LRX";

          

            //Assert/Act
            Assert.Throws<ArgumentException>(() => parser.ParseInstructions(input));


        }
        [Test]
        public void ParseInstruction_ReturnsEmptyList_FoEmptyInputString()
        {
            //Arrange
            var parser = new InputParser();
            var input = "";
            //Act
            var result = parser.ParseInstructions(input);



            //Assert/Act
            Assert.That(result, Is.Empty);



        }
    }
}