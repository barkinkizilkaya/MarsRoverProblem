using MarsRover.Entities;
using MarsRover.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Interfaces
{
    public class PathChecker : IPathChecker
    {

        Plato _plato;
        public PathChecker(Plato plato)
        {
            _plato = plato;    
        }  
        public bool moveIsPossible(Compass Direction,int xVal,int yVal)
        {
            switch (Direction)
            {
                case Compass.N:
                    {
                        if (yVal > _plato.platoY || yVal < 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }                 
                case Compass.E:
                    {
                        if (xVal > _plato.platoX || xVal < 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                case Compass.G:
                    {
                        if (yVal > _plato.platoY || yVal < 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                case Compass.W:
                    {
                        if (xVal > _plato.platoX || xVal < 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
            }
            bool possible = false;
            return possible;
        }
    }
}
