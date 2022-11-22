public class Teacher : User, ITalk
{
    public Teacher(string fn, string ln) : base(fn, ln)
    {

    }
    public override void sayHello()
    {
        Console.WriteLine($"Hi, I am a teacher. My name is {this.FullName}");
    }
}