﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BurgerBuilderFactory
    {
        public Hamburger CreateBurger(string name)
        {
            if (name.Equals("VB"))
            {
                var a = new VeggHamburgerBuilder();
                a.BuildHamburger();
                return a.GetHamburger();
            }
            if (name.Equals("VBL"))
            {
                var a = new VeggHambBuilderLettuce();
                a.BuildHamburger();
                return a.GetHamburger();
            }
            if (name.Equals("CB"))
            {
                var a = new CheesBurgerBuilder();
                a.BuildHamburger();
                return a.GetHamburger();
            }
            if (name.Equals("CBB"))
            {
                var a = new CheeseAndBeaconBurgerBuilder();
                a.BuildHamburger();
                return a.GetHamburger();
            }
            throw new ArgumentException($"cannot create burget {name} !");
        }
    }
}
