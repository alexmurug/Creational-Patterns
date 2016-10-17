using System.Collections.Generic;

namespace AbstractFactoryPattern.AbstractProduct
{
    public abstract class Vehicle
    {
        public List<string> Accessories = new List<string>();
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Body { get; set; }
        public int Doors { get; set; }

        public abstract void ShowInfo();
    }
}