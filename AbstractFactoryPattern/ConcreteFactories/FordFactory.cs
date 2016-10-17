using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.AbstractProduct;
using AbstractFactoryPattern.ConcreteProducts;

namespace AbstractFactoryPattern.ConcreteFactories
{
    internal class FordFactory : IVehicleFactory
    {
        public Vehicle CreateEconomyCar()
        {
            return new FordFocus();
        }

        public Vehicle CreateRacingCar()
        {
            return new FordGT1();
        }

        public Vehicle CreateSUV()
        {
            return new FordExplorer();
        }
    }
}