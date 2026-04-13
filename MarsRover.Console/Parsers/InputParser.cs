using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.ConsoleApp.Parsers
{
    public class InputParser
    {
        public List<Instruction> ParseInstructions(string input)
        {
            var instructions = new List<Instruction>();
            foreach( char c in input)
            {
                Instruction instruction = Enum.Parse<Instruction>(c.ToString());
                instructions.Add(instruction);
            }
            return instructions;
        }

        public Position ParsePositions(string input) 
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input can not be empty");
            }

            var positions = input.Split(' ');
            int x = int.Parse(positions[0]);
            int y = int.Parse(positions[1]);
            CompassDirection facing = Enum.Parse<CompassDirection>(positions[2]);
            return new Position(x, y, facing);



        }
    }
}
