using System;

namespace Shape
{
    public abstract class ThreeDShape
    {
        private String type;    // Sphere, Cylinder, Cone etc...

        public ThreeDShape(String type)
        {
            this.type = type;
        }

        // Read-only property for type.
        public String Type
        {
            get
            {
                return type;
            }
        }

        public abstract double CalcVolume();

        public override string ToString()
        {
            return "a " + type + " shape";
        }
    }


    // Subclass.
    public class Sphere : ThreeDShape
    {
        private double radius;

        // Constructors
        public Sphere(double radius) : base("Sphere")
        {
            Radius = radius;
        }

        public Sphere() : this(0)
        {
        }

        // Read-Write property for radius
        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if(value >= 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ApplicationException("Radius must be a positive integer");
                }
            }
        }


        // Calculate the volume of the sphere
        public override double CalcVolume()
        {
            return Math.PI * radius * radius * radius;
        }

        public override string ToString()
        {
            return base.ToString() + " of radius: " + radius.ToString();
        }
    }
}

// Test class
class Test
{
    public static void Main()
    {
        // Poly Collection
        Shape.ThreeDShape[] collection = { new Shape.Sphere(), new Shape.Sphere(10) };

        foreach (Shape.ThreeDShape s in collection)
        {
            Console.WriteLine(s + " volume: " + s.CalcVolume());
        }
        Console.ReadLine();
    }
}
