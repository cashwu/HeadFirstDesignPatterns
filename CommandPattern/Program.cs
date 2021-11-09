using System;
using System.Collections.Generic;
using CommandPattern;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ac = new AirConditioner();

            var fanUpCommand = new FanUpCommand(ac);
            var fanDownCommand = new FanDownCommand(ac);
            var degreesUpCommand = new DegreesUpCommand(ac);
            var degreesDownCommand = new DegreesDownCommand(ac);
            
            var invoker = new Invoker();
            invoker.SetCommand(fanUpCommand);
            invoker.SetCommand(fanDownCommand);
            invoker.SetCommand(degreesUpCommand);
            invoker.SetCommand(degreesDownCommand);


            Console.WriteLine($"ac degrees - {ac.Degrees}");
            
            invoker.Operate(EnumType.DegreesDown);
            invoker.Operate(EnumType.DegreesUp);
            
            Console.WriteLine($"ac fan - {ac.Fan}");
            
            invoker.Operate(EnumType.FanUp);
            invoker.Operate(EnumType.FanDown);
        }
    }
}

public class Invoker
{
    private static readonly Dictionary<EnumType, ICommand> CommandMap = new();

    public void SetCommand(ICommand command)
    {
        CommandMap.Add(command.Type, command);
    }

    public void Operate(EnumType type)
    {
        CommandMap[type].Execute();
    }
}