using System;
using FactoryPattern.AbstractFactory;
using FactoryPattern.FactoryMethod;
using FactoryPattern.SimpleFactory;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple factory
            SimpleFactory();

            // factory method
            // FactoryMethod();

            // abstract factory
            // AbstractFactory();
        }

        private static void SimpleFactory()
        {
            var obj = Factory.Create(EnumType.C);
            Console.WriteLine(obj);
        }

        private static void FactoryMethod()
        {
            var product = new Product
            {
                Name = "iphone 13",
                Weight = 10,
                Size = new Size
                {
                    Length = 30,
                    Width = 20,
                    Height = 10
                }
            };

            var store = new AppleStore(product);
            var fee = store.Checkout();
            Console.WriteLine(fee);
        }

        private static void AbstractFactory()
        {
            var theme = new DarkThemeFactory();
            var button = theme.createButton();
            var input = theme.createInput();

            Console.WriteLine(button.Name);
            Console.WriteLine(input.Name);
        }
    }
}