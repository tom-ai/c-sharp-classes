public class AnotherClient : ICallback
{
    public void Callback(int x)
    {
        Console.WriteLine("AnotherCallback is a being used");
        Console.WriteLine("x squared is " + x * x);
    }
}