using System;
using System.Diagnostics;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            
            client.Operation();

            // var logDecorator = new LogDecorator(client);
            // var speedDecorator = new SpeedDecorator(logDecorator);
            //
            // var finalClient = speedDecorator;
            // finalClient.Operation();
        }
    }

    public class Client : IDecorator
    {
        public void Operation()
        {
            Console.WriteLine("do something ...");
        }
    }

    public interface IDecorator
    {
        void Operation();
    }

    public class LogDecorator : IDecorator
    {
        private readonly IDecorator _decorator;

        public LogDecorator(IDecorator decorator)
        {
            _decorator = decorator;
        }

        public void Operation()
        {
            Console.WriteLine("log decorator before");

            _decorator.Operation();

            Console.WriteLine("log decorator after");
        }
    }

    public class SpeedDecorator : IDecorator
    {
        private readonly IDecorator _decorator;

        public SpeedDecorator(IDecorator decorator)
        {
            _decorator = decorator;
        }

        public void Operation()
        {
            var sw = new Stopwatch();
            sw.Start();

            _decorator.Operation();

            sw.Stop();

            Console.WriteLine($"speed milliseconds ~ {sw.Elapsed.TotalMilliseconds}");
        }
    }
}