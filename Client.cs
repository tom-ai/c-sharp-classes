public class Client : ICallback
{
    public void Callback(int x)
    {
        Console.WriteLine("Callback called with " + x);
    }

    public void AnotherMethod()
    {
        Console.WriteLine("This is an additional class not defined in the interface");
    }
}