using MarsRover.Entities;
using MarsRover.Enums;
using MarsRover.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Move
{
    public class roverAction : IroverAction
    {
        IPathChecker _pathChecker;
        Rover _rover;

        public roverAction(IPathChecker pathChecker, Rover rover)
        {
            _pathChecker = pathChecker;
            _rover = rover;
        }
        public void TurnLeft()
        {
            switch (_rover.Looking)
            {
                case Compass.N:
                    _rover.Looking = Compass.W;
                    break;
                case Compass.E:
                    _rover.Looking = Compass.N;
                    break;
                case Compass.G:
                    _rover.Looking = Compass.E;
                    break;
                case Compass.W:
                    _rover.Looking = Compass.G;
                    break;
            }
        }
        public void TurnRight()
        {
            switch (_rover.Looking)
            {
                case Compass.N:
                    _rover.Looking = Compass.E;
                    break;
                case Compass.E:
                    _rover.Looking = Compass.G;
                    break;
                case Compass.G:
                    _rover.Looking = Compass.W;
                    break;
                case Compass.W:
                    _rover.Looking = Compass.N;
                    break;
            }
        }
        public bool Move()
        {
            bool moveSuccess = true ;
            if (_rover.Looking == Compass.N)
            {
                var tempY = _rover.rovery + 1;
                var result = _pathChecker.moveIsPossible(_rover.Looking, _rover.roverx, tempY);
                if (!result)
                {
                    return false;
                }
                else
                    _rover.rovery += 1;
            }
            else if (_rover.Looking == Compass.W)
            {
                var tempX = _rover.roverx - 1;
                var result = _pathChecker.moveIsPossible(_rover.Looking, tempX, _rover.rovery);
                if (!result)
                {
                    return false;
                }
                _rover.roverx -= 1;
            }
            else if (_rover.Looking == Compass.E)
            {
                var tempX = _rover.roverx + 1;
                var result = _pathChecker.moveIsPossible(_rover.Looking, tempX, _rover.rovery);
                if (!result)
                {
                    return false;
                }
                _rover.roverx += 1;
            }
            else if (_rover.Looking == Compass.G)
            {
                var tempY = _rover.rovery - 1;
                var result = _pathChecker.moveIsPossible(_rover.Looking, _rover.roverx, tempY);
                if (!result)
                {
                    return false;
                }
                _rover.rovery -= 1;
            }
            else
                return false;
            return moveSuccess;
        }
        public bool Run(char[] moveLetters)
        {
            bool moveResult = false;
            foreach (var item in moveLetters)
            {       
                var letter = item.ToString();
                if (letter == "L")
                {
                    TurnLeft();
                }
                else if (letter == "R")
                {
                    TurnRight();
                }
                else if (letter == "M")
                {
                    moveResult = Move();
                    if (!moveResult)
                    {
                        Console.WriteLine("Movement is not possible to " + _rover.Looking + " current coordinates of rover is " + _rover.roverx + "," + _rover.rovery);
                        break;
                    }
                }
            }
            Console.WriteLine(_rover.roverx + "," + _rover.rovery + "," + _rover.Looking);
            return moveResult;
        }

    
    }
}
