public class Teacher : User
{
    public override void SayHello()
    {
        Console.WriteLine($"Hi, I am a teacher. My name is {this.FullName}");
    }
}