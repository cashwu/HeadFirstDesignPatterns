namespace FactoryPattern.AbstractFactory
{
    public interface IInput
    {
        string Name { get; }
    }

    class DarkInput : IInput
    {
        public string Name => "-- dark input --";
    }
    
    class PurpleInput : IInput
    {
        public string Name => "-- purple input --";
    }
}