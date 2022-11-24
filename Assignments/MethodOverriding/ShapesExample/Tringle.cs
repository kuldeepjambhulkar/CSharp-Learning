using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExample
{
    internal class Tringle : Shape
    {
        float tBase = 2, height = 4;
        double area;
        public override void calculateArea()
        {
            area = 0.5 * this.tBase * this.height;
            Console.WriteLine("Area of Tringle: " + area);
        }
    }
}
