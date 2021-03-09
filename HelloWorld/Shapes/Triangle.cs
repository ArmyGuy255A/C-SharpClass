using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Shapes
{
    class Triangle : Shape<Triangle>
    {
        public Triangle() : base(3)
        {

        }

        public int baselength { get; set; }
        public int height { get; set; }
    }
}
