using MarsRover.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Interfaces
{
    public interface IPathChecker
    {
        bool moveIsPossible(Compass Direction, int xVal, int yVal); 
    }
}
