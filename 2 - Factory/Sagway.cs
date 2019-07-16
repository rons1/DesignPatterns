using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sagway : Vehicle
    {
        protected string madeIn;

        public Sagway(string model, float cylinder, string color, int numberOfWheels, string madeIn) : base(model, cylinder, color, numberOfWheels)
        {
            this.madeIn = madeIn;
        }

        public override string ToString()
        {
            return "Sagway " + base.ToString() + $" {madeIn}";
        }
    }
}
