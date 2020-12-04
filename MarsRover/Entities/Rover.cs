using MarsRover.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Entities
{
    public class Rover
    {
        int _roverx;
        int _rovery;
        Compass _looking;

        public Rover(int roverx, int rovery, Compass look)
        {
            _roverx = roverx;
            _rovery = rovery;
            Looking = look;
        }

        public int roverx { get => _roverx; set => _roverx = value; }
        public int rovery { get => _rovery; set => _rovery = value; }
        public Compass Looking { get => _looking; set => _looking = value; }
    }
}
