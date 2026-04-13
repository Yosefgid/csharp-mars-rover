using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.ConsoleApp
{
    //We only want to hold values and pass them around so it's best practice to use records as opposed to normal class
    //no behaviour in a data class
    public record Position(int X, int Y, CompassDirection Facing);
}
