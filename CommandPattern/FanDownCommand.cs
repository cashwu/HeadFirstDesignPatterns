using System;

namespace CommandPattern
{
    public class FanDownCommand : ICommand
    {
        private readonly AirConditioner _ac;
    
        public EnumType Type => EnumType.FanDown;

        public FanDownCommand(AirConditioner ac)
        {
            _ac = ac;
        }

        public void Execute()
        {
            if (_ac.Fan > 1)
            {
                _ac.Fan -= 1;
            }
            
            Console.WriteLine($"ac fan - {_ac.Fan}");
        }
    }
}