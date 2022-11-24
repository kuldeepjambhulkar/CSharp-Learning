using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExample
{
    internal class Circle : Shape
    {
        float radius = 2;
        double area;
        public override void calculateArea()
        {
            area = 3.14 * this.radius * this.radius;
            Console.WriteLine("Area of Circle: " + area);
        }
    }
}
