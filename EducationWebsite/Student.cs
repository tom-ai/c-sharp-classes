class Student : User
{
    public override void SayHello()
    {
        Console.WriteLine($"Hey, my name is {this.FullName} - I am a student");
    }
}