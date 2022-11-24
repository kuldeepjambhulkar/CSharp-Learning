using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExample
{
    internal class Square : Shape
    {
        float side = 4, area;

        public override void calculateArea( )
        {
            area = this.side * this.side;
            Console.WriteLine("Area of Square: " + area);
        }
    }
}
