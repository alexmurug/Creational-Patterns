using System;
using PrototypePattern.ConcretePrototype;

namespace PrototypePattern
{
    internal class Program
    {
        private static void Main()
        {
            var truck = new Truck();
            var driver = new Driver();


            var truck2 = truck.Clone() as Truck;
            var driver2 = driver.Clone() as Driver;


            if (truck2 != null)
                Console.WriteLine("Model: {0}, Weight: {1}", truck.Model, truck2.Weight);

            if (driver2 != null)
                Console.WriteLine("Age: {0}, Category: {1}", driver2.Age, driver2.Category);

            Console.Read();
        }
    }
}