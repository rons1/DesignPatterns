using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CheeseAndBeaconBurgerBuilder : CheesBurgerBuilder
    {
        protected void PrepareBeacon()
        {
            hamburger.PrepareTopping("Beacon");
        }

    }
}
