class Student : User
{
    public override void SayHello()
    {
        Console.WriteLine($"Hi, I am student. My name is {this.FullName}");
    }
}