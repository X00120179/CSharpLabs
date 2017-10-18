using System;

namespace Shape
{
    // Vertex class
    public class Vertex
    {
        public int X { get; set; }  // Stores X co-ordinates.
        public int Y { get; set; }  // Stores Y co-ordinates.

        // Vertex Constructor
        public Vertex(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return "X: " + X + "Y: " + Y;
        }
    }


    // Enum for the colour of the shapes.
    public enum ShapeColour
    {
        Red, Green, Blue
    }


    public abstract class Shape
    {
        // Using ShapeColour enumerator to get and set the colour of the shape.
        public ShapeColour Colour { get; set; }

        // Shape Constructor.
        public Shape(ShapeColour colour)
        {
            this.Colour = colour;
        }

        // Show the user the colour of the shape by overriding ToString() method.
        public override string ToString()
        {
            return "A " + Colour + " shape";
        }

        public abstract void Translate(Vertex amount);

    }


    // Line class (Inherits Shape)
    public class Line : Shape
    {
        private Vertex v1, v2;

        // No default constructor

        // Line Constructor
        public Line(int x1, int y1, int x2, int y2, ShapeColour colour) : base(colour)
        {
            this.v1 = new Vertex(x1, y1);
            this.v2 = new Vertex(x2, y2);
        }

        // Read-Write properties for X and Y co-ordinates.
        public int X1
        {
            get
            {
                return v1.X;
            }

            set
            {
                v1.X = value;
            }
        }

        public int Y1
        {
            get
            {
                return v1.Y;
            }

            set
            {
                v1.Y = value;
            }
        }

        public int X2
        {
            get
            {
                return v2.X;
            }

            set
            {
                v2.X = value;
            }
        }

        public int Y2
        {
            get
            {
                return v2.Y;
            }

            set
            {
                v2.Y = value;
            }
        }

        // Overriding ToString() method.
        public override string ToString()
        {
            return "A " + Colour + " Line from " + X1 + "," + Y1 + " to " + X2 + "," + Y2;
        }

        // Move the line.
        public override void Translate(Vertex amount)
        {
            v1.X += amount.X;
            v2.X += amount.X;
            v1.Y += amount.Y;
            v2.Y += amount.Y;
        }
    }


    // Circle Class (Inherits Shape)
    public class Circle : Shape
    {
        private Vertex origin;
        public int Radius { get; set; }

        // No default constructor

        public Circle(int x1, int y1, int radius, ShapeColour colour) : base(colour)
        {
            this.origin = new Vertex(x1, y1);
            this.Radius = radius;
        }

        public int X
        {
            get
            {
                return origin.X;
            }

            set
            {
                origin.X = value;
            }
        }

        public int Y
        {
            get
            {
                return origin.Y;
            }

            set
            {
                origin.Y = value;
            }
        }

        // Calculate the area of the circle.
        public virtual double CalcArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Show.
        public override string ToString()
        {
            return "A " + Colour + " Circle at " + X + "," + Y + " radius " + Radius + " area " + " " + this.CalcArea();
        }

        // Move the circle.
        public override void Translate(Vertex amount)
        {
            origin.X += amount.X;
            origin.Y += amount.Y;
        }
    }


    // Test class.
    class Test
    {
        public static void Main()
        {
            // Create a collection of shapes.
            Shape[] shapes = { new Line(2, 2, 3, 3, ShapeColour.Blue), new Circle(5, 5, 50, ShapeColour.Red) };

            // Display on the console.
            foreach (Shape s in shapes)
            {
                Console.WriteLine("Before\t:\t" + s);     // ToString().
                s.Translate(new Vertex(10, 10));
                Console.WriteLine("After\t:\t" + s);      // ToString().
            }

            Console.ReadLine();
        }
    }
}
