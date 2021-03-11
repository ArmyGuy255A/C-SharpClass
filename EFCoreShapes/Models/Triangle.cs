using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EFCoreShapes.Models
{
    public class Triangle : Shape
    {
        [DisplayName("ShortSide")]
        public int a { get; set; }
        [DisplayName("LongSide")]
        public int b { get; set; }
        [DisplayName("Hypotenuse")]
        public int c { get; set; }
    }
}
