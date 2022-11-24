using System;

namespace ShapesExample { 
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape square = new Square();
            square.calculateArea();
            // Output: Area of Square: 16

            Shape circle = new Circle();
            circle.calculateArea();
            // Output: Area of Circle: 12.56

            Shape tringle = new Tringle();
            tringle.calculateArea();
            // Output: Area of Tringle: 4
        }
    }
}