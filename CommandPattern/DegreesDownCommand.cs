using System;

namespace CommandPattern
{
    public class DegreesDownCommand : ICommand
    {
        private readonly AirConditioner _ac;
    
        public EnumType Type => EnumType.DegreesDown;

        public DegreesDownCommand(AirConditioner ac)
        {
            _ac = ac;
        }

        public void Execute()
        {
            if (_ac.Degrees < 30)
            {
                _ac.Degrees += 1;
            }
            
            Console.WriteLine($"ac degrees - {_ac.Degrees}");
        }
    }
}