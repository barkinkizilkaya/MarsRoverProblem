﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Move
{
    public  interface IroverAction
    {

        void TurnLeft();

        void TurnRight();

        bool Move();


    }
}
