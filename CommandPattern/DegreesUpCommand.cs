using System;

namespace CommandPattern
{
    public class DegreesUpCommand : ICommand
    {
        private readonly AirConditioner _ac;
    
        public EnumType Type => EnumType.DegreesUp;

        public DegreesUpCommand(AirConditioner ac)
        {
            _ac = ac;
        }

        public void Execute()
        {
            if (_ac.Degrees > 20)
            {
                _ac.Degrees -= 1;
            }
            
            Console.WriteLine($"ac degrees - {_ac.Degrees}");
        }
    }
}