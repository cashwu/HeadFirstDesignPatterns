namespace CommandPattern
{
    public interface ICommand
    {
        void Execute();

        EnumType Type { get; }
    }
}