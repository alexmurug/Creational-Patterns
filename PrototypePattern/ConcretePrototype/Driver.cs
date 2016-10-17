using PrototypePattern.Prototype;

namespace PrototypePattern.ConcretePrototype
{
    public class Driver : Clonning
    {
        public Driver()
        {
            Age = 10;
            Category = "A,B,C";
        }

        public int Age { get; }
        public string Category { get; }
    }
}