using System;
using SingletonPattern.Singleton;

namespace SingletonPattern
{
    internal class Program
    {
        private static void Main()
        {
            var bmw = Bmw.GetState();
            bmw.Model = "M3";
            bmw.MotorV = 8;

            var bmw2 = Bmw.GetState();
            Console.WriteLine(bmw.Model);
            Console.WriteLine(bmw.MotorV);
            Console.WriteLine(bmw == bmw2);
            Console.Read();
        }
    }
}