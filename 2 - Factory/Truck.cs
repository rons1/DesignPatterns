using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Truck : Vehicle
    {
        protected string tailer;

        public Truck(string model, float cylinder, string color, int numberOfWheels, string tailer) : base(model, cylinder, color, numberOfWheels)
        {
            this.tailer = tailer;
        }

        public override string ToString()
        {
            return "Truck " + base.ToString() + $" {tailer}";
        }
    }
}
