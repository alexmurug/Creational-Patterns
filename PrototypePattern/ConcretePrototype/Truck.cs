using PrototypePattern.Prototype;

namespace PrototypePattern.ConcretePrototype
{
    public class Truck : Clonning
    {
        public Truck()
        {
            Model = "Scania";
            Weight = 20;
        }

        public string Model { get; }
        public float Weight { get; }
    }
}