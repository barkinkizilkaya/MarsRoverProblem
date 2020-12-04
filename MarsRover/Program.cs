using MarsRover.Entities;
using MarsRover.Enums;
using MarsRover.Interfaces;
using MarsRover.Move;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Get Plato Data
            var platoValues = Console.ReadLine().ToUpper().Replace(" ", "");
            var platoXValue = Convert.ToInt16(platoValues[0].ToString());
            var platoYValue = Convert.ToInt16(platoValues[1].ToString());

            Plato plato = new Plato(platoXValue, platoYValue);

            //Get input for 2 rovers;
            for (int i = 0; i <= 2; i++)
            {
                var initialroverPosition = Console.ReadLine().ToUpper().Replace(" ","").ToCharArray();
                var roverXValue = Convert.ToInt16(initialroverPosition[0].ToString());
                var roverYValue = Convert.ToInt16(initialroverPosition[1].ToString());
                var position = Convert.ToString(initialroverPosition[2]);

                //Set Compass Value  For Intial Value
                Compass roverPosition = Compass.N;
                if (position == "N")
                {
                    roverPosition = Compass.N;
                }
                else if (position == "E")
                {

                    roverPosition = Compass.E;
                }
                else if (position == "W")
                {

                    roverPosition = Compass.W;
                }
                else if (position == "G")
                {
                    roverPosition = Compass.G;
                }
                //Create rover Object
                Rover rover = new Rover(roverXValue, roverYValue, roverPosition);
                //Get move letters and turn for each;
                var moveLetters = Console.ReadLine().ToUpper().ToCharArray();
                //Check before Move
                IPathChecker checker = new PathChecker(plato);
                //Action class 
                roverAction action = new roverAction(checker, rover);  
                action.Run(moveLetters);

            }
        }
    }
}

