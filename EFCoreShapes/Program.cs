using EFCoreShapes.Context;
using EFCoreShapes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreShapes
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ShapesContext dbContext = new ShapesContext();

            //Add in a circle
            Circle c = new Circle();

            dbContext.Circles.Add(c);
            await dbContext.SaveChangesAsync();

            //Get all the circles
            IEnumerable<Circle> circles = dbContext.Circles.ToList();

            Console.WriteLine("Break Here!");
        }
    }
}
