using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Shapes
{
    class Rectangle : Shape<Rectangle>, I3DShape
    {
        public Rectangle() : base(4)
        {

        }
        public int length { get; set; }
        public int height { get; set; }
        public int width { get; set; }

        public override void DrawShape() { }
    }
}
