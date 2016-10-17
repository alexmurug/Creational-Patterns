using System.Reflection;
using FactoryMethodPattern.FactoryBase;

namespace FactoryMethodPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var factory = GetFactory("FactoryMethodPattern.ConcreteFactories.LincolnAviatorFactory");

            var lincolnAviator = factory.CreateVehicle();

            lincolnAviator.ShowInfo();

            factory = GetFactory("FactoryMethodPattern.ConcreteFactories.FordExplorerFactory");

            var fordExplorer = factory.CreateVehicle();

            fordExplorer.ShowInfo();
        }

        private static IVehicleFactory GetFactory(string factoryName)
        {
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IVehicleFactory;
        }
    }
}