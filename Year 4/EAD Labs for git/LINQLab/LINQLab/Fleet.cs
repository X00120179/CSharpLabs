using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLab
{
    public class Car
    {
        // Fields and properties.
        public String Make { get; set; }
        public String Model { get; set; }
        public String Registration { get; set; }
        public int EngineSize { get; set; } // Engine size in CC.

        // Overriding ToString() Method.
        public override string ToString()
        {
            return Make + "\n" + Model + "\n" + Registration + "\n" + EngineSize + "\n";
        }
    }

    // Fleet class.
    class Fleet
    {
        static void Main()
        {
            // Create list of car objects.
            List<Car> fleet = new List<Car>();

            // Adding car objects to the fleet.
            fleet.Add(new Car() { Make = "BMW", Model = "M Sport 5 Series", Registration = "161 D 2341", EngineSize = 2000 });
            fleet.Add(new Car() { Make = "Volkswagen", Model = "Polo", Registration = "03 D 1461", EngineSize = 1200 });
            fleet.Add(new Car() { Make = "Volkswagen", Model = "Passat", Registration = "11 D 1017", EngineSize = 1900 });
            fleet.Add(new Car() { Make = "Audi", Model = "A4 S-line", Registration = "09 D 15967", EngineSize = 2000 });
            fleet.Add(new Car() { Make = "Audi", Model = "A3 S-line", Registration = "141 D 78623", EngineSize = 1900 });
            fleet.Add(new Car() { Make = "Nissan", Model = "Qashqai", Registration = "141 D 10297", EngineSize = 1600 });

            // Running Queries.

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Blue;
            // List all cars in registration order.
            Console.WriteLine("List all cars in registration order.\n");
            // Reset colour
            Console.ResetColor();
            var allCars = fleet.OrderBy(car => car.Registration);
            foreach (var car in allCars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Blue;
            // List the models for all Volkswagen cars in the fleet.
            Console.WriteLine("List the models for all Volkswagen cars in the fleet.\n");
            // Reset colour
            Console.ResetColor();
            var volkswagenCars = fleet.Where(car => car.Make == "Volkswagen").Select(car => car.Model);
            foreach (var car in volkswagenCars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Blue;
            // List the models for all Audi cars in the fleet.
            Console.WriteLine("List the models for all Audi cars in the fleet.\n");
            // Reset colour
            Console.ResetColor();
            var audiCars = fleet.Where(car => car.Make == "Audi").Select(car => car.Model);
            foreach (var car in audiCars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Blue;
            // List all cars in descending engine size order.
            Console.WriteLine("List all cars in descending engine size order.\n");
            // Reset colour
            Console.ResetColor();
            var descendingSize = fleet.OrderByDescending(car => car.EngineSize);
            foreach (var car in descendingSize)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Blue;
            // List just the make and model for cars whose engine size is 1600 cc.
            Console.WriteLine("List just the make and model for cars whose engine size is 1600 cc.\n");
            // Reset colour
            Console.ResetColor();
            var makesandmodels = fleet.Select(car => new { car.Make, car.Model });
            foreach (var car in makesandmodels)
            {
                Console.WriteLine(car.Make + " " + car.Model);
            }

            Console.WriteLine();

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Blue;
            // Count the number of cars whose engine size is 1600 cc or less.
            Console.WriteLine("Count the number of cars whose engine size is 1600 cc or less.\n");
            // Reset colour
            Console.ResetColor();
            var count = fleet.Where(car => car.EngineSize <= 1600).Count();
            Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
