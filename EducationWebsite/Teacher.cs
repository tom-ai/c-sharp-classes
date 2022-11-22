public class Teacher : User
{
    public Teacher(string fn, string ln) : base(fn, ln)
    {

    }
    public override void SayHello()
    {
        Console.WriteLine($"Hi, I am a teacher. My name is {this.FullName}");
    }
}