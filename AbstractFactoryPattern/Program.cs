using System;
using System.Collections.Generic;
using System.Reflection;
using AbstractFactoryPattern.AbstractFactory;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        private static void Main()
        {
            foreach (var factory in GetFactories())
            {
                factory.CreateEconomyCar().ShowInfo();
                factory.CreateRacingCar().ShowInfo();
                factory.CreateSUV().ShowInfo();
                Console.WriteLine();
            }
            Console.Read();
        }

        private static IEnumerable<IVehicleFactory> GetFactories()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in types)
                if (type.GetInterface(typeof(IVehicleFactory).ToString()) != null)
                    yield return Activator.CreateInstance(type) as IVehicleFactory;
        }
    }
}