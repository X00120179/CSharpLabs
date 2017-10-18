//Lee Healy - X00120179
using System;

namespace Divisor
{
    public class Calculator
    {
        // Divide first by second unless second is zero.
        public static double Divide(double first, double second)
        {
            if (second == 0)
            {
                throw new ArgumentException("Error: attempt to divide by 0");
            }
            else
            {
                return first / second;
            }
        }
    }


    // Tests.
    class Test
    {
        public static void Main()
        {
            try
            {
                double first = 0, second = 0;

                // Take in user inputs.
                bool valid = true;
                do
                {
                    try
                    {
                        Console.Write("Enter 1st number: ");
                        first = Double.Parse(Console.ReadLine());
                        valid = true;
                    }
                    catch (FormatException)
                    {
                        valid = false;
                    }
                    catch (OverflowException)
                    {
                        valid = false;
                    }
                } while (!valid);


                do
                {
                    try
                    {
                        Console.Write("Enter 2nd number: ");
                        second = Double.Parse(Console.ReadLine());
                        valid = true;
                    }
                    catch (Exception)                                   // cathes both Format and Overflow exceptuons
                    {
                        valid = false;
                    }

                } while (!valid);

                Console.WriteLine(Calculator.Divide(first, second));
            }
            catch (ArgumentException e1)                                // i.e. divide by zero attempt
            {
                Console.WriteLine(e1.Message);
            }

            Console.ReadLine();
        }
    }
}

