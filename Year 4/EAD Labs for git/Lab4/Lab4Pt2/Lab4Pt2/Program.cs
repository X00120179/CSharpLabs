// Lee Healy - X00120179
using System;

namespace AcademicRecord
{
    public class ModuleCAResults
    {
        public String Name { get; set; }
        public int Credits { get; set; }
        public String StudentName { get; set; }

        private const int MAX = 50;         // Max of 50 results.
        private double[] results = new double[MAX];     // Creates array.
        private int next = 0;       // Next free slot for a result in the results array.

        // Return a string to contain all module details including results.
        public override string ToString()
        {
            String output = "Module\t\t: " + Name + "\nCredits\t\t: " + Credits + "\nStudent Name\t: " + StudentName + "\nResults:\n";
            for (int i = 0; i < next; i++)
            {
                output += results[i] + "%, ";
            }
            return output;
        }

        
        // Indexer based on CA result.
        public double this[int CA]
        {
            get
            {
                int index = CA - 1;     // CA 1 is at index 0.
                if ((index >= 0) && (index < next))  // Valid range.
                {
                    return results[index];  // Return the result.
                }
                else
                {
                    throw new Exception("Invalid CA number");
                }
            }

            set
            {
                // Add a result or change an existing result.

                int index = CA - 1;
                // No gaps allowed, must overwrite existing result or add at end, and must have space in array.
                if ((index >= 0) && (index <= next) && (index < (MAX)))
                {
                    results[index] = value;                     // Set the result.
                    if (index == next)
                    {
                        next++;                                 // That was a new result.
                    }
                }
                else
                {
                    throw new Exception("Invalid CA number!");
                }
            }
        }
    }

    // Test class.
    class Test
    {
        public static void Main()
        {
            try
            {
                ModuleCAResults results = new ModuleCAResults() { Name = "oosdev2", Credits = 10, StudentName = "Jane Doe" };
                results[1] = 20;                    // New result for CA1.
                results[2] = 40;
                results[3] = 60;
                results[1] = 25;                    // Overwrite.
                results[3] = 65;                    // Overwrite.
                results[4] = 99;

                Console.WriteLine(results);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
