namespace FlyweightPattern
{
    public interface IMealFlyweight
    {
        string Name { get; }

        void Serve(string size);
    }
}