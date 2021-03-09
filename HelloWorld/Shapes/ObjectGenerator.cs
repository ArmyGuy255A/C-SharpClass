using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Shapes
{
    static class ObjectGenerator
    {
        public static IEnumerable<Circle> GenerateShapes(Circle circle)
        {
            return new Circle[10];
        }

        public static IEnumerable<Triangle> GenerateShapes(Triangle circle)
        {
            return new Triangle[10];
        }

        public static IEnumerable<Rectangle> GenerateShapes(Rectangle circle)
        {
            return new Rectangle[10];
        }
    }
}
