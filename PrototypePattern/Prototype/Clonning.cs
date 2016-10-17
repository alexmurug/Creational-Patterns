using System;

namespace PrototypePattern.Prototype
{
    public abstract class Clonning : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}