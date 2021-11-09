using System;

namespace CommandPattern
{
    public class FanUpCommand : ICommand
    {
        private readonly AirConditioner _ac;

        public EnumType Type => EnumType.FanUp;

        public FanUpCommand(AirConditioner ac)
        {
            _ac = ac;
        }

        public void Execute()
        {
            if (_ac.Fan < 5)
            {
                _ac.Fan += 1;
            }

            Console.WriteLine($"ac fan - {_ac.Fan}");
        }
    }
}