using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Shapes
{
    class Circle : Shape<Circle>
    {
        public Circle() : base(0)
        {
            pi = 3.14;
        }

        private double rad;
        public double Rad
        {
            get { return rad; }
            set { rad = value;  }
        }

        public double Area
        {
            get { return (pi * radius * radius);  }
        }

        public int radius { get; set; }
        public int diameter { get; set; }
        private double pi { get; set; }

        private double GetPi ()
        {
            //return this.radius;
            return pi;
        }

        

    }
}
