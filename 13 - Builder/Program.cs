using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HamburgerBuilder> menu = new List<HamburgerBuilder>();
            menu.Add(new VeggHamburgerBuilder());
            menu.Add(new VeggHambBuilderLettuce());

            Hamburger hamb = PrepareHamburger("CBB");
            Hamburger hamb2 = PrepareHamburger("VB");
        }

        static Hamburger PrepareHamburger(string name)
        {
            return (new BurgerBuilderFactory()).CreateBurger(name);
        }
    }
}
