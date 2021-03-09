using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Shapes
{

    static class Calculations
    {
        const double pi = 3.14;

        public static double CalculateArea(Circle circle)
        {
            return (Math.Pow(circle.radius, 2) * pi);
        }

        public static double CalculateArea(Rectangle rectangle)
        {
            return (rectangle.height * rectangle.length);
        }

        public static double CalculateArea(Triangle triangle)
        {
            return (.5 * triangle.baselength * triangle.height);
        }

        //private static double Pi { get { return 3.14; } }

    }
}
