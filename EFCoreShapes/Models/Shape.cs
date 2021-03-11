using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

/// <summary>
/// This is a collection of the programs blah blah blah.
/// </summary>
namespace EFCoreShapes.Models
{
    /// <summary>
    /// This is the generic shape
    /// </summary>
    public class Shape
    {
        [Key]
        public int Id { get; set; }
        public int NumberOfSides { get; set; }
    }
}
