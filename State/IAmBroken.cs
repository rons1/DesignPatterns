using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class IAmBroken : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("Light is already off....");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Light is broken....");
            return this;
        }
        public ILightState Fix()
        {
            Console.WriteLine("Fixing light....");
            return new IAmOff();
        }
    }
}
