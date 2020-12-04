using MarsRover.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover;
using MarsRover.Interfaces;
using MarsRover.Move;
using MarsRover.Enums;

namespace Rover.Test
{
    [TestClass]
    public class RoverTest
    {
        [TestMethod]
        public void Is_rover_Handle_Incoorect_Letter() 
        {


            var rg = new MarsRover.Entities.Rover(2, 2, Compass.N);
            Plato plato = new Plato(5, 5);
            string letters = "F";
            var moveLetters = letters.ToCharArray();
            IPathChecker checker = new PathChecker(plato);
            roverAction action = new roverAction(checker, rg);

            Assert.IsFalse(action.Run(letters.ToCharArray()), "Can  Not go anywhere");


        }

        [TestMethod]
        public void Is_rover_Handle_Incoorect_Movement()
        {

            var rg = new MarsRover.Entities.Rover(2, 2, Compass.N);
            Plato plato = new Plato(5, 5);
            string letters = "MMMMM";
            var moveLetters = letters.ToCharArray();
            IPathChecker checker = new PathChecker(plato);
            roverAction action = new roverAction(checker, rg);

            Assert.IsFalse(action.Run(letters.ToCharArray()), "Heyy you are in space now!");


        }

        [TestMethod]
        public void Is_rover_Can_Go_Ground()
        {

            var rg = new MarsRover.Entities.Rover(2, 2, Compass.N);
            Plato plato = new Plato(5, 5);
            string letters = "RRMMMMM";
            var moveLetters = letters.ToCharArray();
            IPathChecker checker = new PathChecker(plato);
            roverAction action = new roverAction(checker, rg);

            Assert.IsFalse(action.Run(letters.ToCharArray()), "How you can not go underground");


        }

        [TestMethod]
        public void Is_wrong_data_can_Handle()
        {

            var rg = new MarsRover.Entities.Rover(6, 6, Compass.N);
            Plato plato = new Plato(5, 5);
            string letters = "MM";
            var moveLetters = letters.ToCharArray();
            IPathChecker checker = new PathChecker(plato);
            roverAction action = new roverAction(checker, rg);

            Assert.IsFalse(action.Run(letters.ToCharArray()), "Houston we have a Problem !");

        }

    }
}
