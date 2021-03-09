using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Shapes
{

    class Shape<T>
    {
        public Shape()
        {

        }
        public Shape(int sides)
        {
            numberOfSides = sides;
        }

        public int numberOfSides { get; set; }
        
        public double CalucalateArea (T shape) {
            double result = 0;
            switch (shape)
            {
                case Circle c:
                    result = Calculations.CalculateArea(c);
                    break;
                case Rectangle r:
                    result = Calculations.CalculateArea(r);
                    break;
                case Triangle t:
                    result = Calculations.CalculateArea(t);
                    break;
                default:
                    
                    break;
            }
            
            return result;
        }
    }
}
