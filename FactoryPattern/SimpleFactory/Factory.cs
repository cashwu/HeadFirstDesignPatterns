using System;

namespace FactoryPattern.SimpleFactory
{
    public static class Factory
    {
        public static MyObject Create(EnumType type)
        {
            MyObject obj = type switch
            {
                EnumType.A => new MyObjectA(),
                EnumType.B => new MyObjectB(),
                EnumType.C => new MyObjectC(),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };

            return obj;
        }
    }
}