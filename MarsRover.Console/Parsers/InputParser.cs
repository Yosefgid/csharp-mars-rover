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
            return new Position(1, 2, CompassDirection.N);
            //var positions = input.Split(' ');
            //int x = int.Parse(positions[0]);
            //int y = int.Parse(positions[1]);
            //CompassDirection facing = Enum.Parse<CompassDirection>(positions[2]);
            //return new pos
           

        }
    }
}
