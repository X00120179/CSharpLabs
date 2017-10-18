using System;

namespace Shape
{
    // Interface.
    public interface IHasVolume
    {
        double CalcVolume();    // Public and abstract.
    }


    // Sphere class.
    public class Sphere : System.Object, IHasVolume
    {
        private double radius;

        // Constructor.
        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public Sphere() : this(0)
        {
        }

        // Read-Write property for radius.
        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value >= 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ApplicationException("Radius must be a positive integer.");
                }
            }
        }

        // Calculate volume of the sphere.
        // Can be overriden in a subclass.
        public virtual double CalcVolume()
        {
            return Math.PI * radius * radius * radius;
        }

        // Override the ToString() method.
        public override String ToString()
        {
            return "A Sphere of radius: " + radius.ToString();
        }
    }
}


// Test class
class Test
{
    public static void Main()
    {
        // Collection of Sphere objects referenced by HasVolume refs.
        Shape.IHasVolume[] collection = { new Shape.Sphere(), new Shape.Sphere(10) };

        // Display collection to user.
        foreach (Shape.IHasVolume s in collection)
        {
            Console.WriteLine(s + " volume: " + s.CalcVolume());
        }
        Console.ReadLine();
    }
}