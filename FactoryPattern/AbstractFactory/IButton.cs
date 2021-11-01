namespace FactoryPattern.AbstractFactory
{
    public interface IButton
    {
        string Name { get; }
    }

    class DarkButton : IButton
    {
        public string Name => "-- dark button --";
    }
    
    class PurpleButton : IButton
    {
        public string Name => "-- purple button --";
    }
}