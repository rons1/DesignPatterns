using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle c = new Circle(new Point(5, 5), 50.5);

            Console.WriteLine(c);

            DoStuffWithCircle(c.clone());

            Console.WriteLine(c);

            DoStuffWithCircle(c);

            Console.WriteLine(c);
        }

        public static void DoStuffWithCircle(Shape c)
        {
            ((Circle)c).Center.X = 15;
            ((Circle)c).Area = -5;
        }
    }
}
