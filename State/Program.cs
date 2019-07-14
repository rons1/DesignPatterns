﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context(new IAmOn());

            ctx.pressedOff();
            ctx.pressedOn();
            ctx.pressedOff();
            ctx.pressedOn();
            ctx.pressedOn();
            ctx.pressedFix();
            ctx.pressedOff();
            ctx.pressedOff();

        }
    }
}
