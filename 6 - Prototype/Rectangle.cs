using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    public class Rectangle : Shape
    {

        public Point TopLeftPoint { get; set; }

        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(Point topLeftPoint, double height, double width)
        {
            this.TopLeftPoint = topLeftPoint;
            this.Height = height;
            this.Width = width;
        }

        public override string ToString()
        {
            return $"Rectangle Top Left Point is {TopLeftPoint} , Height is {Height}, and Width is {Width}";
        }

        public override Shape clone()
        {
            return new Rectangle(TopLeftPoint.clone(), Height, Width);
        }
    }
}
