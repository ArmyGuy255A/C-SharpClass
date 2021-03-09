using System;
using System.Collections.Generic;
using System.Linq;
using HelloWorld.Shapes;

namespace HelloWorld
{
    public enum MyShapes
    {
        Circle = 0,
        Square,
        Triangle
    }

    public enum MathOperation
    {
        Addition = 0,
        Subtraction,
        Multiplication,
        Division
    }

    [Flags]
    public enum AdminRoles
    {
        GlobalAdministrator = 1,
        HelpdeskAdministrator = 2,
        UserAdministrator = 4,
        AccountAdministrator = 8,
        TeamsAdministrator = 16
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IEnumerable<string> strings = new List<string>();
            var hello = new List<string>();

            Circle c = new Circle();
            Rectangle r = new Rectangle();


            IEnumerable<Shape<Circle>> shapes = new List<Circle>();
            List<Circle> shapes1 = new List<Circle>();

            //Console.WriteLine(c.numberOfSides);
            Shape<Circle> s = new Circle();
            var shp = new Circle();


            Shape<Circle> aCircle = (Shape<Circle>)c;
            Shape<Circle> bCircle = c;

            string text = "Hello" + "World";
            text += "Test";

            bool isTrue = false;
            bool isFalse = false;
            if (isTrue == true && isFalse == true)
            {

            }

            if (isTrue)
            {

            } else if (isFalse)
            {

            } else
            {

            }

            MyShapes myshape = MyShapes.Circle;
            switch (myshape)
            {
                case MyShapes.Circle:
                    //Get the radius
                    break;
                case MyShapes.Square:
                    //Get the Area
                    break;
                case MyShapes.Triangle:
                    //Get the Hypotenuse
                    break;
                default:
                    //I'm an undefined Shape
                    break;
            }


            for (int i = 0; i < 10; i++)
            {

            }

            //foreach (Shape shpe in shapes)
            //{

            //}

            //GenerateShapes(totalNumberOfShapes: 10);
            //var x = GenerateShapes(1000);
            //GenerateShapes(10, 4);
            //GenerateShapes(totalNumberOfShapes: 3);

            int[] numbers = new int[10];
            string[] dow = new string[7];
            dow[0] = "Saturday";
            dow[1] = "Sunday";
            dow[2] = "Monday";

            //var circles = GenerateShapes(new Circle());
            //var rectangles = GenerateShapes(new Rectangle());
            //var triangles = GenerateShapes(new Triangle());

            //void PrintNumberOfSides (Shape shape)
            //{
            //    Console.WriteLine(shape.numberOfSides);
            //}

            //IEnumerable<Shape> myShapes = GenerateShapes(10);
            //foreach(var bobsShapes in myShapes)
            //{
            //    PrintNumberOfSides(bobsShapes);
            //}

            Circle myCircle = new Circle();
            Triangle myTriangle = new Triangle();
            Rectangle myRectangle = new Rectangle();

            //Shape[] myShapes = new Shape[30];
            //for (int i = 0; i < myShapes.Length; i++)
            //{
            //    Random random = new Random();
            //    int randomNumber = random.Next(0, 100);
            //    if (randomNumber % 3 == 0)
            //    {
            //        myShapes[i] = new Circle();
            //    } else if (randomNumber % 3 == 1)
            //    {
            //        myShapes[i] = new Triangle();
            //    } else
            //    {
            //        myShapes[i] = new Rectangle();
            //    }
            //}

            //Use LINQ to find all the cicles
            //var myLINQcircles = myShapes.Where(s => s.GetType() == typeof(Circle)).ToList();
            //var myShapesWithZeroSides = myShapes.Where(s => s.numberOfSides == 0).ToList();
            //var myOrderedShapes = myShapes.OrderBy(s => s.numberOfSides).ToList();


            string helloworld = "Hello World";
            String helloworldDotNet = new String("Hello World");

            // Use a static class to generate shapes.
            var circles= ObjectGenerator.GenerateShapes(new Circle());
            Rectangle rect = new Rectangle();

            Console.WriteLine();

            //int<int> numbers = new int[10, 10];
            //numbers[0] = new int[10, 10];

        }

        //public static IEnumerable<Shape> GenerateShapes(int totalNumberOfShapes, int totalNumberOfSides = 0)
        //{
        //    Shape[] shapes = new Shape[totalNumberOfShapes];

        //    for (int i = 0; i < shapes.Length; i++)
        //    {
        //        shapes[i] = new Shape() { numberOfSides = i };
        //    }

        //    return shapes;
        //}

        //public static IEnumerable<Shape> GenerateShapes(Shape theShape)
        //{
        //    Shape[] shapes;

        //    switch (theShape)
        //    {
        //        case Circle c:
        //            shapes = new Circle[10];
        //            break;
        //        case Rectangle r:
        //            shapes = new Rectangle[10];
        //            break;
        //        case Triangle t:
        //            shapes = new Triangle[10];
        //            break;
        //        default:
        //            shapes = new Shape[10];
        //            break;
        //    }
        //    return shapes;
        //}
    }
}
