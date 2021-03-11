using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreShapes.Models
{
    /// <summary>
    /// This is a circle shape
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// This will provide you a radius for a circle
        /// </summary>
        public int radius { get; set; }
    }
}
