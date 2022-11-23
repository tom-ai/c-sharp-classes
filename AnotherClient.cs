public class AnotherClient : ICallback
{
    public void Callback(int x)
    {
        Console.WriteLine("AnotherCallback is a being used");
        Console.WriteLine("x squared is " + x * x);
    }
}

public class ClientB : ClientA.NestedIF
{
    public bool isNotNegative(int x)
    {
        return x < 0 ? false : true;
    }
}